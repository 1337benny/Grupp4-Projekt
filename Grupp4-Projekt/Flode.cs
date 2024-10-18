using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupp4_Projekt
{
    public abstract class Flode
    {
        public Flode()
        {
            Namn = "Okänt namn";
            Url = "Okänd URL";
        }
        public Flode(string namn, string url)
        {
            Namn = namn;
            Url = url;
        }

        public string Namn { get; set; }
        public string Url { get; set; }

    }
}
