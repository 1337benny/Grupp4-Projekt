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
            PodcastControllerObjekt = new PodcastController();
        }
        private PodcastController PodcastControllerObjekt { get; set; }


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
            PodcastControllerObjekt.laggTillPodcast(podAntalAvsnitt, podNamn, podUrl);
        }
    }
}
