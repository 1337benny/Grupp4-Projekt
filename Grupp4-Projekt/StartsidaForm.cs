﻿using System;
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
    public partial class StartsidaForm : Form
    {
        public StartsidaForm()
        {
            InitializeComponent();
            visaAllaMinaPoddar();

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
            PodcastController podcastController = new PodcastController();

            List<Podcast> podcasts = podcastController.visaMinaPoddar();
            foreach (Podcast podcast in podcasts) //Loopa igenom alla Podcast objekt i den lokala listan
            {
                lbMinaPoddar.Items.Add(podcast.Namn);  // Lägg till podcastens namn i listboxen
            }


        }

        
    }
}
