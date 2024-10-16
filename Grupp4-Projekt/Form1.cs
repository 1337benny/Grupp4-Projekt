
using System.Diagnostics;

namespace Grupp4_Projekt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Test enTest = new Test();

            tbTest.Text = enTest.TestMetod();
            Debug.WriteLine("Hej");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartsidaForm startsida = new StartsidaForm();
            startsida.ShowDialog();
            this.Close();
        }
    }
}
