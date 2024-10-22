using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Serializable]
    public class Podcast : Flode
    {

        //Parameterlös konstruktor
        public Podcast() : base()  
        {
            AntalAvsnitt = 0;  
        }

        //Konstruktor
        public Podcast(int antalAvsnitt, string titel, string url, string namn) : base(titel, url, namn) 
        {
            AntalAvsnitt = antalAvsnitt;
        }

       

        public int AntalAvsnitt { get; set; }
    }
}
