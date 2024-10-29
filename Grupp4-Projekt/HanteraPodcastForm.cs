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
        public HanteraPodcastForm()
        {
            InitializeComponent();
            this.CenterToScreen();
            Controller = new DataController();
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
            List<Kategori> kategoriLista = Controller.visaMinaKategorier();

            foreach (Kategori kategori in kategoriLista)
            {

                List<Podcast> kategorinsPoddar = kategori.KategorinsPodcasts;

                foreach (Podcast podcast in kategorinsPoddar)
                {
                    string[] podInfo = { podcast.Namn, podcast.Titel, kategori.Namn };
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

            foreach(Kategori kategori in kategoriLista)
            {
                cbValjKategori.Items.Add(kategori.Namn);

                if (kategori.Namn.Equals(valdKategori))
                {
                   index = kategoriLista.IndexOf(kategori);
                }
                
            }

            cbValjKategori.SelectedIndex = index;
        }
    }
}
