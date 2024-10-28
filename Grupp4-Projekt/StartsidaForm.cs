using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Models;

namespace Grupp4_Projekt
{
    public partial class StartsidaForm : Form, IFormInterface
    {
        public StartsidaForm()
        {
            InitializeComponent();
            centreraForm();
            visaAllaMinaPoddar();
            skapaStandardKategoriXml();


        }

        public void centreraForm()
        {
            this.CenterToScreen();
        }

        public void tillbakaKnapp()
        {
            this.Close();
        }

        private void btnLaggTillNyPodd_Click(object sender, EventArgs e)
        {
            this.Hide();
            LaggTillPoddForm laggTillPodd = new LaggTillPoddForm();
            laggTillPodd.ShowDialog();
            this.Close();
        }



        private void visaAllaMinaPoddar()
        {


            DataController podcastController = new DataController();

            List<Kategori> kategorier = podcastController.visaMinaKategorier();
            foreach (Kategori kategori in kategorier) //Loopa igenom alla Podcast objekt i den lokala listan
            {


                List<Podcast> kategorinsPoddar = kategori.KategorinsPodcasts;

                foreach (Podcast podcast in kategorinsPoddar)
                {
                    string[] podInfo = { podcast.Namn, podcast.Titel, kategori.Namn, podcast.AntalAvsnitt.ToString() };
                    ListViewItem item = new ListViewItem(podInfo);
                    lvMinaPoddar.Items.Add(item);
                }


            }


        }

        private void btnHanteraKategorier_Click(object sender, EventArgs e)
        {
            this.Hide();
            HanteraKategorierForm hanteraKategorier = new HanteraKategorierForm();
            hanteraKategorier.ShowDialog();
            this.Close();
        }

        private void skapaStandardKategoriXml()
        {

            if (!File.Exists("kategoriLista.xml"))
            {
                DataController dataController = new DataController();

                dataController.laggTillKategori("Humor");
                dataController.laggTillKategori("Dokumentär");
                dataController.laggTillKategori("Nöje");
                dataController.laggTillKategori("Sport");
                dataController.laggTillKategori("Fakta");
                dataController.laggTillKategori("Utbildning");
                dataController.laggTillKategori("Nyheter");
                dataController.laggTillKategori("Fantasi");
            }
                
        }

        private void btnAvsluta_Click(object sender, EventArgs e)
        {
            tillbakaKnapp();
        }
    }
}
