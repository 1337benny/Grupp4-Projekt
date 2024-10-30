//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Models;

//namespace DAL.Repository
//{
//    public class PodcastRepository : IRepository<Podcast>
//    {
//        GeneriskSerialiserare<Kategori> GeneriskSerialiserare;
//        List<Kategori> KategoriLista;
//        List<Podcast> PodcastLista;

//        public PodcastRepository()
//        {
//            GeneriskSerialiserare = new GeneriskSerialiserare<Kategori>("kategoriLista.xml");
//            KategoriLista = new List<Kategori>();
//            PodcastLista = new List<Podcast>();

//        }

//        public List<Podcast> HamtaAlla()
//        {
//            KategoriLista = GeneriskSerialiserare.Deserialisera();

//            foreach (Kategori kategori in KategoriLista) 
//            { 
//                foreach (Podcast podcast in kategori.KategorinsPodcasts)
//                {
//                    PodcastLista.Add(podcast);
//                }
                
//            }


//            return PodcastLista;
//        }

//        public Podcast HamtaMedNamn(string titel)
//        {
//            Podcast podcast = null;

//            foreach (Podcast objekt in HamtaAlla())
//            {
//                if (objekt.Titel.Equals(titel))
//                {
//                    podcast = objekt;
//                }
//            }

//            return podcast;
//        }


//        public void LaggTill(Kategori kategori)
//        {

//            KategoriLista.Add(kategori);
//            Spara();
//        }

//        public void Uppdatera(int index, Kategori uppdateradKategori)
//        {
//            if (index >= 0)
//            {

//                KategoriLista[index] = uppdateradKategori;
//                Spara();
//            }
//            Spara();
//        }

//        public void Radera(int index)
//        {
//            KategoriLista.RemoveAt(index);
//            Spara();
//        }

//        public void Spara()
//        {
//            GeneriskSerialiserare.Serialisera(KategoriLista);
//        }

//    }
//}
