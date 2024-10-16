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
    }
}
