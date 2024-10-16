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

namespace Grupp4_Projekt
{
    public partial class LaggTillPoddForm : Form
    {
        public LaggTillPoddForm()
        {
            InitializeComponent();
        }

        private void btnTillbaka_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartsidaForm startsida = new StartsidaForm();
            startsida.ShowDialog();
            this.Close();
        }

        private void btnHamtaUrl_Click(object sender, EventArgs e)
        {
            if (tbUrl.Text == "" || tbUrl.Text == null)
            {
                //Vänligen fyll i URL
            }
            else { 
                string sokUrl = tbUrl.Text; //den url som användaren klistrat in

                using XmlReader reader = XmlReader.Create(sokUrl);  //xmlreadern hämtar den url som användaren angav
                 
                SyndicationFeed feed = SyndicationFeed.Load(reader); //feed innehåller nu all xml text som vi kan använda

                string flodetsNamn = feed.Title.Text; //Hämtar ut titeln på feedet (poddens namn)
                
                tbFlodetsNamn.Text = flodetsNamn; // sätter poddens namn i textboxen


                //Går igenom alla avsnitt i flödet för att räkna hur många det är
                int antalAvsnittInt = 0;
                foreach (SyndicationItem item in feed.Items)
                {
                    antalAvsnittInt++;
                }

                string antalAvsnitt = antalAvsnittInt.ToString(); //Gör om integern till string

                tbAntalAvsnitt.Text = antalAvsnitt; //Sätter antalet avsnitt i textboxen

                foreach (SyndicationItem item in feed.Items)
                {
                    lbxAllaAvsnitt.Items.Add(item.Title.Text);
                }



            }

        }
    }
}
