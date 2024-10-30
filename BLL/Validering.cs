using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Models;

namespace BLL
{
    public class Validering
    {
        public Validering() { }

        public Boolean kollaOmKategoriRedanFinns(string sokTitel, List<Kategori> kategoriLista)
        {
            Boolean kategoriFinns = false;

            foreach (Kategori kategori in kategoriLista)
            {
                if (kategori.Namn.Equals(sokTitel, StringComparison.OrdinalIgnoreCase)){
                    kategoriFinns = true;
                }
            }

            return kategoriFinns;

            
        }

        public Boolean kollaOmPodcastRedanFinns(string sokUrl, List<Kategori> kategoriLista)
        {
            bool podcastFinns = false;

            foreach (Kategori kategori in kategoriLista)
            {
                List<Podcast> podcastLista = kategori.KategorinsPodcasts;

                foreach (Podcast podcast in podcastLista)
                {
                    if (podcast.Url.Equals(sokUrl, StringComparison.OrdinalIgnoreCase))
                    {
                        podcastFinns = true;
                    }
                }
            }

            return podcastFinns;
        }
    }
}
