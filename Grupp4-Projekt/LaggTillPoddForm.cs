using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using BLL;
using DAL;
using Models;

namespace Grupp4_Projekt
{
    public partial class LaggTillPoddForm : Form
    {
        private string podNamn;
        private string podUrl;
        private int podAntalAvsnitt;
        private string podEgetNamn;
        private List<Avsnitt> podcastensAvsnitt;
        private KontrollMeddelande meddelande;
        private Validering validering;
        private DataController DataControllerObjekt { get; set; }
        public LaggTillPoddForm()
        {
            InitializeComponent();
            this.CenterToScreen();
            DataControllerObjekt = new DataController();
            meddelande = new KontrollMeddelande();
            validering = new Validering();
            fyllComboboxKategorier();
        }
        

        private void tillStartsidan()
        {
            this.Hide();
            StartsidaForm startsida = new StartsidaForm();
            startsida.ShowDialog();
            this.Close();
        }


        private void btnTillbaka_Click(object sender, EventArgs e)
        {
            tillStartsidan();
        }

        private void btnHamtaUrl_Click(object sender, EventArgs e)
        {
            


            //Töm listan om det fanns avsnitt i den innan 
            podcastensAvsnitt = new List<Avsnitt>();

            lbAllaAvsnitt.Items.Clear(); //Nollställer listan från föregående sökning
            rtbAvsnittInfo.Text = ""; //Nollställer avsnittrutan från föregående sökning

            if (string.IsNullOrEmpty(tbUrl.Text))
            {
                meddelande.visaMeddelande(this, "Vänligen fyll i en URL.");
                return;
            }

            string sokUrl = tbUrl.Text; //lagrar url i en variabel string

            SyndicationFeed feed = null;
            try
            {
                feed = XmlHanterare.hamtaUrl(sokUrl);
            }
            catch (FileNotFoundException ex)
            {
                meddelande.visaMeddelande(this, "Kunde inte hämta angiven URL.\n\nVänligen ange en korrekt RSS-länk.");
                tbUrl.Text = string.Empty;
                return;
            }
            catch (XmlException ex)
            {
                meddelande.visaMeddelande(this, "Kunde inte hämta angiven URL.\n\nVänligen ange en korrekt RSS-länk.");
                tbUrl.Text = string.Empty;
                return;
            }
            catch(Exception ex) 
            {
                meddelande.visaMeddelande(this, "Oväntat fel");
                tbUrl.Text = string.Empty;
                return;
            }



            tbNamn.Text = feed.Title.Text; //sätter flödets titel i textboxen


            //Räkna antalet avsnitt
            int antalAvsnittInt = 0;
            foreach (SyndicationItem item in feed.Items)
            {
                antalAvsnittInt++;
            }

            tbAntalAvsnitt.Text = antalAvsnittInt.ToString(); //Sätter antalet avsnitt i textboxen

            //Skriver ut titlarna på varje avsnitt och skapar nya avsnitt-objekt
            foreach (SyndicationItem item in feed.Items)
            {
                lbAllaAvsnitt.Items.Add(item.Title.Text);
                string avsnittNamn = "";
                string avsnittBeskrivning = "";

                avsnittNamn = item.Title.Text;

                try
                {
                    avsnittBeskrivning = item.Summary != null ? item.Summary.Text : "";
                }
                catch (NullReferenceException ex)
                {
                    Debug.WriteLine(ex.Message);
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                }
                

                Avsnitt nyttAvsnitt = new Avsnitt(avsnittNamn, avsnittBeskrivning);

                podcastensAvsnitt.Add(nyttAvsnitt);

            }

            podAntalAvsnitt = antalAvsnittInt;
            podNamn = feed.Title.Text;
            podUrl = tbUrl.Text;

        }

        private void lbAllaAvsnitt_Click(object sender, EventArgs e)
        {
            string valtAvsnittTitel = lbAllaAvsnitt.SelectedItem.ToString();
            string sokUrl = podUrl;

            
            SyndicationFeed feed = XmlHanterare.hamtaUrl(sokUrl);

            string avsnittBeskrivning = "";
            foreach (SyndicationItem item in feed.Items)
            {

                if (item.Title.Text.Equals(valtAvsnittTitel))
                {
                    try
                    {
                        // Kontrollera om item.Summary är null innan vi försöker använda det
                        if (item.Summary != null)
                        {
                            avsnittBeskrivning = item.Summary.Text;
                        }
                        else
                        {
                            avsnittBeskrivning = "Går inte att läsa beskrivningen"; 
                        }
                    }
                    catch (Exception ex) 
                    {
                        avsnittBeskrivning = "Går inte att läsa beskrivningen";
                    }
                }

                rtbAvsnittInfo.Text = avsnittBeskrivning;

            }




        }

        private void btnPrenumerera_Click(object sender, EventArgs e)
        {
            podEgetNamn = tbEgetNamn.Text;
            string kategori = cbValjKategori.SelectedItem.ToString();

            if (podAntalAvsnitt == 0)
            {
                meddelande.visaMeddelande(this, "Vänligen hämta en URL innan du prenumererar!");
                return;
            }

            List<Kategori> kategoriLista = DataControllerObjekt.visaMinaKategorier();

            if (validering.kollaOmPodcastRedanFinns(podUrl, kategoriLista)) 
            {
                meddelande.visaMeddelande(this, "Du prenumererar redan på denna podcast.");
                return;
            }

            Podcast nyPodcast = new Podcast(podAntalAvsnitt, podcastensAvsnitt, podNamn, podUrl, podEgetNamn);

            
            DataControllerObjekt.laggTillPodcastIKategori(nyPodcast, kategori);

            Debug.WriteLine("kategori: " + kategori);

            tillStartsidan();
        }

        private void fyllComboboxKategorier()
        {
            List<Kategori> kategoriLista = DataControllerObjekt.visaMinaKategorier();

            foreach (Kategori kategori in kategoriLista)
            {
                cbValjKategori.Items.Add(kategori.Namn);
            }

            cbValjKategori.SelectedIndex = 0;
        }
    }
}
