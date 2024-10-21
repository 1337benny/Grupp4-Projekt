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
        public Podcast(int antalAvsnitt, string namn, string url) : base(namn, url) 
        {
            AntalAvsnitt = antalAvsnitt;
        }

       

        public int AntalAvsnitt { get; set; }
    }
}
