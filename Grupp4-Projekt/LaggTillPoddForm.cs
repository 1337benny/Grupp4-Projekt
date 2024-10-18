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

namespace Grupp4_Projekt
{
    public partial class LaggTillPoddForm : Form
    {
        private string podNamn;
        private string podUrl;
        private int podAntalAvsnitt;
        public LaggTillPoddForm()
        {
            InitializeComponent();
        }

        private void btnTillbaka_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartsidaForm startsida = new StartsidaForm();
            startsida.ShowDialog();
            this.Close();
        }

        private void btnHamtaUrl_Click(object sender, EventArgs e)
        {
            lbAllaAvsnitt.Items.Clear(); //Nollställer listan från föregående sökning
            rtbAvsnittInfo.Text = ""; //Nollställer avsnittrutan från föregående sökning

            string sokUrl = tbUrl.Text; //lagrar url i en variabel string

            XmlReader urlLasare = XmlReader.Create(sokUrl);
            SyndicationFeed feed = SyndicationFeed.Load(urlLasare);

            tbNamn.Text = feed.Title.Text; //sätter flödets titel i textboxen


            //Räkna antalet avsnitt
            int antalAvsnittInt = 0;
            foreach (SyndicationItem item in feed.Items)
            {
                antalAvsnittInt++;
            }

            tbAntalAvsnitt.Text = antalAvsnittInt.ToString(); //Sätter antalet avsnitt i textboxen

            //Skriver ut titlarna på varje avsnitt
            foreach (SyndicationItem item in feed.Items)
            {
                lbAllaAvsnitt.Items.Add(item.Title.Text);
            }

            podAntalAvsnitt = antalAvsnittInt;
            podNamn = feed.Title.Text;
            podUrl = tbUrl.Text;

        }

        private void lbAllaAvsnitt_Click(object sender, EventArgs e)
        {
            string valtAvsnittTitel = lbAllaAvsnitt.SelectedItem.ToString();
            string sokUrl = tbUrl.Text;

            XmlReader urlLasare = XmlReader.Create(sokUrl);
            SyndicationFeed feed = SyndicationFeed.Load(urlLasare);

            string avsnittBeskrivning = "";
            foreach (SyndicationItem item in feed.Items)
            {
                if (item.Title.Text.Equals(valtAvsnittTitel))
                {
                    avsnittBeskrivning = item.Summary.Text;
                }

                rtbAvsnittInfo.Text = avsnittBeskrivning;
            }




        }

        private void btnPrenumerera_Click(object sender, EventArgs e)
        {
            // Skapa en ny podcast
            Podcast nyPodcast = new Podcast(podAntalAvsnitt, podNamn, podUrl);

            // Skapa en instans av den generiska serialiseraren
            GeneriskSerialiserare<Podcast> enGeneriskSerialiserare = new GeneriskSerialiserare<Podcast>("podcastLista.xml");

            // Hämta den befintliga podcast-listan (eller en ny om filen inte finns)
            List<Podcast> podcastLista;

            try
            {
                podcastLista = enGeneriskSerialiserare.Deserialisera();
            }
            catch (FileNotFoundException)
            {
                // Om filen inte finns, skapa en ny lista
                podcastLista = new List<Podcast>();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ett fel inträffade vid läsning av filen: {ex.Message}");
                return;
            }

            // Lägg till den nya podcasten i listan
            podcastLista.Add(nyPodcast);

            // Serialisera listan tillbaka till XML-filen
            enGeneriskSerialiserare.Serialisera(podcastLista);
        }
    }
}
