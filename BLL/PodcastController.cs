using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PodcastController
    {
        public PodcastController() { 
        
        }

        public void laggTillPodcast(int podAntalAvsnitt, string podNamn, string podUrl)
        {
            // Skapa en ny podcast
            Podcast nyPodcast = new Podcast(podAntalAvsnitt, podNamn, podUrl);

            // Skapa en instans av den generiska serialiseraren
            GeneriskSerialiserare<Podcast> enGeneriskSerialiserare = new GeneriskSerialiserare<Podcast>("podcastLista.xml");

            // Hämta den befintliga podcast-listan (eller en ny om filen inte finns)
            List<Podcast> podcastLista;

            try
            {
                podcastLista = enGeneriskSerialiserare.Deserialisera();
            }
            catch (FileNotFoundException)
            {
                // Om filen inte finns, skapa en ny lista
                podcastLista = new List<Podcast>();
            }
            catch (Exception ex)
            {
                //MessageBox.Show($"Ett fel inträffade vid läsning av filen: {ex.Message}");
                Console.WriteLine(ex.Message);
                return;
            }

            // Lägg till den nya podcasten i listan
            podcastLista.Add(nyPodcast);

            // Serialisera listan tillbaka till XML-filen
            enGeneriskSerialiserare.Serialisera(podcastLista);
        }

        public List<Podcast> visaMinaPoddar()
        {
            GeneriskSerialiserare<Podcast> minaPoddar = new GeneriskSerialiserare<Podcast>("podcastLista.xml");

            List<Podcast> podcasts = minaPoddar.Deserialisera();  // Använd Deserialisera() för att deserialisera en lista in i en lokal variabel

            
            return podcasts;
        }
    }
}
