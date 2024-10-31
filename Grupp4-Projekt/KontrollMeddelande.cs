using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grupp4_Projekt
{
    public class KontrollMeddelande
    {
        public KontrollMeddelande() { }

        public void visaMeddelande(Form form, string meddelande)
        {
            MessageBox.Show(form, meddelande);
            
        }

        public DialogResult visaMeddelande(Form form, string titel, string meddelande)
        {
            DialogResult resultat = MessageBox.Show(form, titel, meddelande, MessageBoxButtons.YesNo);
            return resultat;
        }
    }
}
