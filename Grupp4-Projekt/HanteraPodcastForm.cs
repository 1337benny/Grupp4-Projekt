using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;
using System.Diagnostics;

namespace Grupp4_Projekt
{
    public partial class HanteraPodcastForm : Form
    {
        private DataController Controller;
        private KontrollMeddelande meddelande;

        public HanteraPodcastForm()
        {
            InitializeComponent();
            this.CenterToScreen();
            Controller = new DataController();
            meddelande = new KontrollMeddelande();
            visaMinaPoddar();
        }

        private void btnTillbaka_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form startsida = new StartsidaForm();
            startsida.ShowDialog();
            this.Close();
        }

        private void visaMinaPoddar()
        {
            lvMinaPoddar.Items.Clear();
            List<Kategori> kategoriLista = Controller.visaMinaKategorier();

            foreach (Kategori kategori in kategoriLista)
            {

                List<Podcast> kategorinsPoddar = kategori.KategorinsPodcasts;

                foreach (Podcast podcast in kategorinsPoddar)
                {
                    string[] podInfo = { podcast.Namn, podcast.Titel, kategori.Namn, podcast.Url };
                    ListViewItem item = new ListViewItem(podInfo);
                    lvMinaPoddar.Items.Add(item);
                }

            }
        }

        private void lvMinaPoddar_Click(object sender, EventArgs e)
        {

            ListViewItem podcast = lvMinaPoddar.SelectedItems[0];
            string podNamn = podcast.SubItems[0].Text;
            string podTitel = podcast.SubItems[1].Text;
            string podKategori = podcast.SubItems[2].Text;

            lbPodcastTitel.Text = podTitel;
            tbNyttNamn.Text = podNamn;

            fyllCombobox(podKategori);


        }

        private void fyllCombobox(string valdKategori)
        {
            cbValjKategori.Items.Clear();

            List<Kategori> kategoriLista = Controller.visaMinaKategorier();
            int index = 0;

            foreach (Kategori kategori in kategoriLista)
            {
                cbValjKategori.Items.Add(kategori.Namn);

                if (kategori.Namn.Equals(valdKategori))
                {
                    index = kategoriLista.IndexOf(kategori);
                }

            }

            cbValjKategori.SelectedIndex = index;
        }

        private void btnSparaAndringar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lbPodcastTitel.Text))
            {
                meddelande.visaMeddelande(this, "Vänligen markera podcasten du önskar att ändra.");
                return;
            }

            ListViewItem item = null;
            try
            {
                item = lvMinaPoddar.SelectedItems[0];
            }
            catch (ArgumentOutOfRangeException ex)
            {
                meddelande.visaMeddelande(this, "Vänligen markera vilken podd du vill ändra.");
                return;
            }
            catch (Exception ex)
            {
                meddelande.visaMeddelande(this, "Vänligen markera vilken podd du vill ändra.");
                return;
            }

            
            string url = item.SubItems[3].Text;
            string nyttNamn = tbNyttNamn.Text;
            string nyKategori = cbValjKategori.SelectedItem.ToString();
            string gammalKategori = item.SubItems[2].Text;


            int podcastensIndex = 0;
            int kategorinsIndex = 0;
            int antalAvsnitt = 0;
            List<Avsnitt> avsnittLista = null;
            List<Podcast> podcastLista = null;
            Kategori kategoriAttAndra = null;


            List<Kategori> kategoriLista = Controller.visaMinaKategorier();

            foreach (Kategori kategori in kategoriLista)
            {

                foreach (Podcast podcast in kategori.KategorinsPodcasts)
                {
                    if (podcast.Url.Equals(url))
                    {
                        podcastensIndex = kategori.KategorinsPodcasts.IndexOf(podcast);
                        antalAvsnitt = podcast.AntalAvsnitt;
                        avsnittLista = podcast.PodcastensAvsnitt;
                        podcastLista = kategori.KategorinsPodcasts;
                        kategorinsIndex = kategoriLista.IndexOf(kategori);
                        kategoriAttAndra = kategori;
                        break;
                    }
                }
            }

            Podcast uppdateradPodcast = new Podcast(antalAvsnitt, avsnittLista, lbPodcastTitel.Text, url, nyttNamn);

            if (nyKategori.Equals(gammalKategori))
            {
                podcastLista[podcastensIndex] = uppdateradPodcast;
                kategoriAttAndra.KategorinsPodcasts = podcastLista;

                Controller.uppdateraPodcast(kategorinsIndex, kategoriAttAndra);
                visaMinaPoddar();
                meddelande.visaMeddelande(this, "Du har uppdaterat podcastens namn!");
                return;
            }


            podcastLista.RemoveAt(podcastensIndex);

            foreach (Kategori kategori in kategoriLista)
            {
                if (kategori.Namn.Equals(nyKategori))
                {
                    podcastLista = kategori.KategorinsPodcasts;
                    kategoriAttAndra = kategori;
                    kategorinsIndex = kategoriLista.IndexOf(kategori);
                }
            }

            podcastLista.Add(uppdateradPodcast);
            kategoriAttAndra.KategorinsPodcasts = podcastLista;
            Controller.uppdateraPodcast(kategorinsIndex, kategoriAttAndra);
            meddelande.visaMeddelande(this, "Du har uppdaterat podcasten!");

            visaMinaPoddar();

        }

        private void btnRaderaPodcast_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lbPodcastTitel.Text))
            {
                meddelande.visaMeddelande(this, "Vänligen markera podcasten du önskar att radera.");
                return;
            }

            ListViewItem item = null;
            try
            {
                item = lvMinaPoddar.SelectedItems[0];
            }
            catch (ArgumentOutOfRangeException ex)
            {
                meddelande.visaMeddelande(this, "Vänligen markera vilken podd du vill radera.");
                return;
            }
            catch (Exception ex)
            {
                meddelande.visaMeddelande(this, "Vänligen markera vilken podd du vill radera.");
                return;
            }

            
            string url = item.SubItems[3].Text;


            int podcastensIndex = 0;
            int kategorinsIndex = 0;
            string titel = "";
            Kategori kategoriAttAndra = null;
            List<Podcast> podcastLista = null;
            List<Kategori> kategoriLista = Controller.visaMinaKategorier();
            
            foreach (Kategori kategori in kategoriLista)
            {
                foreach (Podcast podcast in kategori.KategorinsPodcasts)
                {
                    if (podcast.Url.Equals(url))
                    {
                        podcastensIndex = kategori.KategorinsPodcasts.IndexOf(podcast);
                        titel = podcast.Titel;
                        podcastLista = kategori.KategorinsPodcasts;
                        kategorinsIndex = kategoriLista.IndexOf(kategori);
                        kategoriAttAndra = kategori;
                        break;
                    }
                }
            }


            DialogResult dialogResult = meddelande.visaMeddelande(this, "Är du säker på att du vill ta bort podcasten: " + titel + "?", "Radera kategori?");


            if (dialogResult == DialogResult.Yes)
            {
                podcastLista.RemoveAt(podcastensIndex);
                kategoriAttAndra.KategorinsPodcasts = podcastLista;

                Controller.uppdateraPodcast(kategorinsIndex, kategoriAttAndra);
                
                HanteraPodcastForm form = new HanteraPodcastForm();
                this.Hide();
                form.ShowDialog();
                this.Close();
            }
            else
            {

                return;
            }
            
            



        }
    }
}
