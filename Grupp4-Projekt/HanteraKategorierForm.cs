using BLL;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grupp4_Projekt
{
    public partial class HanteraKategorierForm : Form
    {
        private DataController DataController;
        public HanteraKategorierForm()
        {
            InitializeComponent();
            visaMinaKategorier();
            this.CenterToScreen();
            this.DataController = new DataController();

        }

        private void btnTillbaka_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartsidaForm startsida = new StartsidaForm();
            startsida.ShowDialog();
            this.Close();
        }

        

        private void btnSparaNyKategori_Click(object sender, EventArgs e)
        {

            KontrollMeddelande meddelande = new KontrollMeddelande();

            if (tbNyKategoriNamn.Text.Equals(""))
            {
                meddelande.visaMeddelande(this, "Vänligen fyll i ett kategori-namn innan du sparar.");
                return;
            }


            DataController dataController = new DataController();
            Boolean visaFelmeddelande = dataController.laggTillKategori(tbNyKategoriNamn.Text);

            

            if (visaFelmeddelande)
            {
                
                meddelande.visaMeddelande(this, "Du har redan en kategori med detta namn.");
            }
            
            else
            {
                meddelande.visaMeddelande(this, "Kategorin '" + tbNyKategoriNamn.Text + "'  har lagts till!");
                tbNyKategoriNamn.Text = "";
            }

            lvMinaKategorier.Items.Clear();
            visaMinaKategorier();
        }









        public void visaMinaKategorier()
        {
            DataController dataController = new DataController();
            List<Kategori> kategoriLista = dataController.visaMinaKategorier();

            int antalPoddarIKategorin = 0;
            foreach (Kategori kategori in kategoriLista)
            {
                String kategorinsNamn = kategori.Namn;
                List<Podcast> kategorinsPodcast = kategori.KategorinsPodcasts;

                foreach (Podcast podcast in kategorinsPodcast)
                {
                    antalPoddarIKategorin++;
                }

                string[] kategoriInfo = { kategorinsNamn, antalPoddarIKategorin.ToString()};
                ListViewItem item = new ListViewItem(kategoriInfo);
                lvMinaKategorier.Items.Add(item);
                antalPoddarIKategorin = 0;
            }
        }

        

    }
}
