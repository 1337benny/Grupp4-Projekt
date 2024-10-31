using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Models;

namespace Grupp4_Projekt
{
    public partial class StartsidaForm : Form
    {
        private DataController Controller;
        public StartsidaForm()
        {
            InitializeComponent();
            Controller = new DataController();
            centreraForm();
            visaAllaMinaPoddar();
            skapaStandardKategoriXml();
            fyllComboboxMedKategorier();

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
            lvMinaPoddar.Items.Clear();
            rtbBeskrivning.Text = string.Empty;
            lbAvsnitt.Items.Clear();

            List<Kategori> kategorier = Controller.visaMinaKategorier();
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


                Controller.laggTillKategori("Humor");
                Controller.laggTillKategori("Dokumentär");
                Controller.laggTillKategori("Nöje");
                Controller.laggTillKategori("Sport");
                Controller.laggTillKategori("Fakta");
                Controller.laggTillKategori("Utbildning");
                Controller.laggTillKategori("Nyheter");
                Controller.laggTillKategori("Fantasi");
            }

        }

        private void btnAvsluta_Click(object sender, EventArgs e)
        {
            tillbakaKnapp();
        }

        private void btnHanteraMinaPoddar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form hanteraPoddarForm = new HanteraPodcastForm();
            hanteraPoddarForm.ShowDialog();
            this.Close();
        }

        private void lvMinaPoddar_Click(object sender, EventArgs e)
        {
            lbAvsnitt.Items.Clear();
            rtbBeskrivning.Text = string.Empty;

            ListViewItem item = lvMinaPoddar.SelectedItems[0];
            string titel = item.SubItems[1].Text;


            List<Kategori> kategoriLista = Controller.visaMinaKategorier();

            foreach (Kategori kategori in kategoriLista)
            {
                foreach (Podcast podcast in kategori.KategorinsPodcasts)
                {
                    if (podcast.Titel.Equals(titel))
                    {
                        foreach (Avsnitt avsnitt in podcast.PodcastensAvsnitt)
                        {
                            lbAvsnitt.Items.Add(avsnitt.Titel);
                        }
                    }
                }
            }
        }

        private void lbAvsnitt_Click(object sender, EventArgs e)
        {
            rtbBeskrivning.Text = string.Empty;

            string avsnittNamn = lbAvsnitt.SelectedItem.ToString();

            List<Kategori> kategoriLista = Controller.visaMinaKategorier();

            foreach (Kategori kategori in kategoriLista)
            {
                foreach (Podcast podcast in kategori.KategorinsPodcasts)
                {

                    foreach (Avsnitt avsnitt in podcast.PodcastensAvsnitt)
                    {
                        if (avsnitt.Titel.Equals(avsnittNamn))
                        {
                            rtbBeskrivning.Text = avsnitt.Beskrivning;
                        }
                    }

                }
            }
        }

        private void cbFiltreraPaKategori_SelectedValueChanged(object sender, EventArgs e)
        {
            lvMinaPoddar.Items.Clear();
            lbAvsnitt.Items.Clear();
            rtbBeskrivning.Text = string.Empty;
            string kategoriNamn = cbFiltreraPaKategori.SelectedItem.ToString();


            List<Kategori> kategoriLista = Controller.visaMinaKategorier();

            foreach (Kategori kategori in kategoriLista)
            {
                if (kategori.Namn.Equals(kategoriNamn))
                {
                    foreach (Podcast podcast in kategori.KategorinsPodcasts)
                    {
                        string[] podInfo = { podcast.Namn, podcast.Titel, kategori.Namn, podcast.AntalAvsnitt.ToString() };
                        ListViewItem item = new ListViewItem(podInfo);
                        lvMinaPoddar.Items.Add(item);
                    }

                }
            }


        }

        public void fyllComboboxMedKategorier()
        {
            cbFiltreraPaKategori.Items.Clear();

            List<Kategori> kategoriLista = Controller.visaMinaKategorier();

            foreach (Kategori kategori in kategoriLista)
            {
                cbFiltreraPaKategori.Items.Add(kategori.Namn);
            }
        }

        private void btnAterstall_Click(object sender, EventArgs e)
        {
            visaAllaMinaPoddar();
        }
    }
}
