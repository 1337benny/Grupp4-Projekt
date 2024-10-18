using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupp4_Projekt
{
    public class Kategori
    {
        public Kategori(string namn, List<Podcast> podcastLista) { 
        Namn = namn;
        }

        public string Namn { get; set; }
    }
}
