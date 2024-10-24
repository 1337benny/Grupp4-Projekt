using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupp4_Projekt
{
    public class KontrollMeddelande
    {
        public KontrollMeddelande() { }

        public void visaMeddelande(Form form, string meddelande)
        {
            MessageBox.Show(form, meddelande);
        }
    }
}
