using DAL;
using DAL.Repository;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DataController
    {
        IRepository<Kategori> KategoriRepository;
        public DataController() {
            this.KategoriRepository = new KategoriRepository();
        }

        //public void laggTillPodcast(Podcast nyPodcast)
        //{
            

        //    // Skapa en instans av den generiska serialiseraren
        //    GeneriskSerialiserare<Podcast> enGeneriskSerialiserare = new GeneriskSerialiserare<Podcast>("podcastLista.xml");

        //    // Hämta den befintliga podcast-listan (eller en ny om filen inte finns)
        //    List<Podcast> podcastLista;

        //    try
        //    {
        //        podcastLista = enGeneriskSerialiserare.Deserialisera();
        //    }
        //    catch (FileNotFoundException)
        //    {
        //        // Om filen inte finns, skapa en ny lista
        //        podcastLista = new List<Podcast>();
        //    }
        //    catch (Exception ex)
        //    {
        //        //MessageBox.Show($"Ett fel inträffade vid läsning av filen: {ex.Message}");
        //        Console.WriteLine(ex.Message);
        //        return;
        //    }

        //    // Lägg till den nya podcasten i listan
        //    podcastLista.Add(nyPodcast);

        //    // Serialisera listan tillbaka till XML-filen
        //    enGeneriskSerialiserare.Serialisera(podcastLista);
        //}

        //public List<Podcast> visaMinaPoddar()
        //{
        //    GeneriskSerialiserare<Podcast> minaPoddar = new GeneriskSerialiserare<Podcast>("podcastLista.xml");

        //    List<Podcast> podcasts = minaPoddar.Deserialisera();  // Använd Deserialisera() för att deserialisera en lista in i en lokal variabel

            
        //    return podcasts;
        //}








        public Boolean laggTillKategori(string kategoriNamn)
        {

            Boolean printaMeddelande = false;

            Kategori kategori = new Kategori(kategoriNamn);

            KategoriRepository.LaggTill(kategori);

            //GeneriskSerialiserare<Kategori> enGeneriskSerialiserare = new GeneriskSerialiserare<Kategori>("kategoriLista.xml");

            //List<Kategori> kategoriLista;



            //try
            //{
            //    kategoriLista = enGeneriskSerialiserare.Deserialisera();
            //}
            //catch (FileNotFoundException)
            //{
            //    // Om filen inte finns, skapa en ny lista
            //    kategoriLista = new List<Kategori>();
            //}
            //catch (Exception ex)
            //{
            //    //MessageBox.Show($"Ett fel inträffade vid läsning av filen: {ex.Message}");
            //    Console.WriteLine(ex.Message);
            //    return printaMeddelande;
            //}

            //Validering validering = new Validering();
            //Boolean kategorinFinns = validering.kollaOmKategoriRedanFinns(kategoriNamn, kategoriLista);

            //if (!kategorinFinns) { 
            //// Lägg till den nya podcasten i listan
            //kategoriLista.Add(kategori);

            //// Serialisera listan tillbaka till XML-filen
            //enGeneriskSerialiserare.Serialisera(kategoriLista);
                
            //}
            //else
            //{
            //    printaMeddelande = true;
            //}

            return printaMeddelande;
            
        }

        public List<Kategori> visaMinaKategorier()
        {
            //GeneriskSerialiserare<Kategori> minaKategorier = new GeneriskSerialiserare<Kategori>("kategoriLista.xml");

            //List<Kategori> kategorierLista = minaKategorier.Deserialisera();  // Använd Deserialisera() för att deserialisera en lista in i en lokal variabel


            return KategoriRepository.HamtaAlla();
        }

        public void laggTillPodcastIKategori(Podcast podcast, string kategoriNamn)
        {
            List<Kategori> kategoriLista = KategoriRepository.HamtaAlla();

            Kategori objektet = null;
            int objektetsIndex = 0;
            foreach (Kategori kategori in kategoriLista)
            {
                if (kategori.Namn.Equals(kategoriNamn))
                {
                    List<Podcast> podcastLista = kategori.KategorinsPodcasts;
                    podcastLista.Add(podcast);
                    objektet = kategori;
                     
                }
                //objektetsIndex++;
            }

            objektetsIndex = kategoriLista.IndexOf(objektet);

            KategoriRepository.Uppdatera(objektetsIndex, objektet);

            //GeneriskSerialiserare<Kategori> generiskSerialiserare = new GeneriskSerialiserare<Kategori>("kategoriLista.xml");
            //generiskSerialiserare.Serialisera(kategoriLista);

        }
    }
}
