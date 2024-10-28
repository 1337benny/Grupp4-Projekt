using DAL;
using DAL.Repository;
using Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DataController
    {
        IRepository<Kategori> KategoriRepository;
        Validering Validering;

        public DataController() {
            this.KategoriRepository = new KategoriRepository();
            Validering = new Validering();
        }

        

        public Boolean laggTillKategori(string kategoriNamn)
        {
            Boolean printaMeddelande = false;


            List<Kategori> kategorier = KategoriRepository.HamtaAlla();
            
            if (!Validering.kollaOmKategoriRedanFinns(kategoriNamn, kategorier))
            {
                Kategori kategori = new Kategori(kategoriNamn);

                KategoriRepository.LaggTill(kategori);
            }
            else
            {
                printaMeddelande = true;
            }
            


            return printaMeddelande;
            
        }

        public List<Kategori> visaMinaKategorier()
        {


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
                    //objektetsIndex = kategoriLista.IndexOf(objektet);
                    break;
                }
                objektetsIndex++;
            }

            Debug.WriteLine("index: " + objektetsIndex); 

            KategoriRepository.Uppdatera(objektetsIndex, objektet);

            

        }

        public void raderaKategori(string kategorinsNamn)
        {
            List<Kategori> kategoriLista = KategoriRepository.HamtaAlla();

            var objektet = from kategori in kategoriLista
                           where kategori.Namn.Equals(kategorinsNamn)
                           select kategori;

            int index = 0;
            foreach (var objekt in objektet)
            {
                index = kategoriLista.IndexOf(objekt);
            }

            KategoriRepository.Radera(index);
        }

        public Boolean uppdateraKategoriNamn(string kategorinsNamn, string nyttNamn)
        {
            List<Kategori> kategoriLista = KategoriRepository.HamtaAlla();

            if (Validering.kollaOmKategoriRedanFinns(nyttNamn, kategoriLista))
            {
                //Felmeddelande kategorin kan inte heta detta
                return true;
            }


            var objektet = from kategori in kategoriLista
                           where kategori.Namn.Equals(kategorinsNamn)
                           select kategori;

            Kategori uppdateradKategori = null;
            int index = 0;

            foreach (var objekt in objektet)
            {
                objekt.Namn = nyttNamn;
                uppdateradKategori = objekt;
                index = kategoriLista.IndexOf(objekt);
            }

            KategoriRepository.Uppdatera(index, uppdateradKategori);
            return false;
        }
    }
}
