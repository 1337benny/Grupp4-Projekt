using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Kategori
    {
        public Kategori(string namn) { 
        Namn = namn;
        KategorinsPodcasts = new List<Podcast>();
        }

        public Kategori() {
            Namn = "Tomt namn";
            KategorinsPodcasts = new List<Podcast>();
        }

        public string Namn { get; set; }

        public List<Podcast> KategorinsPodcasts { get; set; }
    }
}
