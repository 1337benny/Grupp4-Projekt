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
        public LaggTillPoddForm()
        {
            InitializeComponent();
            this.CenterToScreen();
            DataControllerObjekt = new DataController();

            fyllComboboxKategorier();
        }
        private DataController DataControllerObjekt { get; set; }

        public void tillStartsidan()
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
            lbAllaAvsnitt.Items.Clear(); //Nollställer listan från föregående sökning
            rtbAvsnittInfo.Text = ""; //Nollställer avsnittrutan från föregående sökning

            string sokUrl = tbUrl.Text; //lagrar url i en variabel string


            SyndicationFeed feed = XmlHanterare.hamtaUrl(sokUrl);


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
            string sokUrl = podUrl;

            //XmlReader urlLasare = XmlReader.Create(sokUrl);
            SyndicationFeed feed = XmlHanterare.hamtaUrl(sokUrl);

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
            podEgetNamn = tbEgetNamn.Text;
            string kategori = cbValjKategori.SelectedItem.ToString();
            
            Podcast nyPodcast = new Podcast(podAntalAvsnitt, podNamn, podUrl, podEgetNamn);

            //DataControllerObjekt.laggTillPodcast(nyPodcast);
            
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
