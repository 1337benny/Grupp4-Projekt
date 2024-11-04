using BLL;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        private KontrollMeddelande meddelande;
        public HanteraKategorierForm()
        {
            InitializeComponent();
            visaMinaKategorier();
            this.CenterToScreen();
            this.DataController = new DataController();
            meddelande = new KontrollMeddelande();
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


            visaMinaKategorier();
        }


        private void visaMinaKategorier()
        {
            lvMinaKategorier.Items.Clear();

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

                string[] kategoriInfo = { kategorinsNamn, antalPoddarIKategorin.ToString() };
                ListViewItem item = new ListViewItem(kategoriInfo);
                lvMinaKategorier.Items.Add(item);
                antalPoddarIKategorin = 0;
            }
        }

        private void btnRaderaKategori_Click(object sender, EventArgs e)
        {
            try
            {
                ListViewItem kategorin = lvMinaKategorier.SelectedItems[0];
                string kategorinsNamn = kategorin.Text;

                DialogResult dialogResult = meddelande.visaMeddelande(this, "Är du säker på att du vill ta bort kategorin: " + kategorinsNamn + "? \n\n Du kommer även ta bort alla poddar i kategorin.", "Radera kategori?");


                if (dialogResult == DialogResult.Yes)
                {
                    DataController.raderaKategori(kategorinsNamn);

                    visaMinaKategorier();
                }
                else
                {

                    return;
                }


            }
            catch (ArgumentOutOfRangeException)
            {
                meddelande.visaMeddelande(this, "Vänligen markera vilken kategori du vill ta bort");

            }




        }

        private void btnBytNamn_Click(object sender, EventArgs e)
        {
            string kategorinsNamn = "";
            try
            {
                ListViewItem kategorin = lvMinaKategorier.SelectedItems[0];
                kategorinsNamn = kategorin.Text;
            }
            catch (ArgumentOutOfRangeException)
            {
                meddelande.visaMeddelande(this, "Vänligen markera vilken kategori du vill ändra.");
                return;
            }

            if (string.IsNullOrEmpty(tbUppdateraNamn.Text))
            {
                meddelande.visaMeddelande(this, "Vänligen fyll i ett nytt namn till kategorin!");
                return;
            }

            Boolean felmeddelande = DataController.uppdateraKategoriNamn(kategorinsNamn, tbUppdateraNamn.Text);

            if (felmeddelande)
            {
                meddelande.visaMeddelande(this, "Du har redan en kategori med detta namn! \n \n Vänligen ange ett annat namn");
                return;
            }


            meddelande.visaMeddelande(this, "Du har uppdaterat kategorins namn!");
            visaMinaKategorier();
            tbUppdateraNamn.Text = "";

        }

        private void lvMinaKategorier_Click(object sender, EventArgs e)
        {
            lbPoddarIKategorin.Items.Clear();

            int antalPoddar = 0;
            string kategoriNamn = "";
            
            
            ListViewItem kategorin = lvMinaKategorier.SelectedItems[0];
            antalPoddar = Int32.Parse(kategorin.SubItems[1].Text);
            kategoriNamn = kategorin.Text;

            tbUppdateraNamn.Text = kategoriNamn;
            if (antalPoddar == 0)
            {
                lbPoddarIKategorin.Items.Add("Du har inga poddar i denna kategori");
                return ;
            }

            List<Kategori> kategoriLista = DataController.visaMinaKategorier();

            

            List<string> poddTitlar = kategoriLista
            .Where(kategori => kategori.Namn.Equals(kategoriNamn))
            .SelectMany(kategori => kategori.KategorinsPodcasts.Select(podcast => podcast.Titel))
            .ToList();

            foreach (string enTitel in poddTitlar)
            {
                lbPoddarIKategorin.Items.Add(enTitel);
            }
        }
    }
}
