using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupp4_Projekt
{
    internal class Podcast
    {
        public Podcast(string namn, string kategori, string url, int antalAvsnitt, int id) {

            Namn = namn;
            Kategori = kategori;
            Url = url;
            AntalAvsnitt = antalAvsnitt;
            Id = id;

        }

        public string Namn { get; set; }

        public string Kategori { get; set; }

        public string Url { get; set; }

        public int AntalAvsnitt { get; set; }

        public int Id { get; set; }



    }
}
