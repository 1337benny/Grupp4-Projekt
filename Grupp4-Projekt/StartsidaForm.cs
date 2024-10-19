using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grupp4_Projekt
{
    public partial class StartsidaForm : Form
    {
        public StartsidaForm()
        {
            InitializeComponent();

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
            GeneriskSerialiserare<Podcast> minaPoddar = new GeneriskSerialiserare<Podcast>("podcastLista.xml");

            List<Podcast> podcasts = minaPoddar.Deserialisera();  // Använd Deserialisera() för att deserialisera en lista in i en lokal variabel

            foreach (Podcast podcast in podcasts) //Loopa igenom alla Podcast objekt i den lokala listan
            {
                lbMinaPoddar.Items.Add(podcast.Namn);  // Lägg till podcastens namn i listboxen
            }
        }

        private void btnVisaPrenumerationer_Click(object sender, EventArgs e)
        {
            visaAllaMinaPoddar();
        }
    }
}
