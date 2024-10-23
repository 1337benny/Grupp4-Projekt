using BLL;
using Models;
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
    public partial class HanteraKategorierForm : Form
    {
        public HanteraKategorierForm()
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

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void btnSparaNyKategori_Click(object sender, EventArgs e)
        {
            DataController dataController = new DataController();
            dataController.laggTillKategori(tbNyKategoriNamn.Text);
        }


    }
}
