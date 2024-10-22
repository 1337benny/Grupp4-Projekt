using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public abstract class Flode
    {
        public Flode()
        {
            Titel = "Okänt namn";
            Url = "Okänd URL";
        }
        public Flode(string titel, string url, string namn)
        {
            Titel = titel;
            Url = url;
            Namn = namn;
        }

        public string Titel { get; set; }
        public string Url { get; set; }

        public string Namn { get; set; }

    }
}
