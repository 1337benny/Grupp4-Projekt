using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DAL.Repository
{
    public class KategoriRepository : IRepository<Kategori>
    {
        GeneriskSerialiserare<Kategori> GeneriskSerialiserare;
        List<Kategori> KategoriLista;
        

        public KategoriRepository()
        {
            GeneriskSerialiserare = new GeneriskSerialiserare<Kategori>("kategoriLista.xml");
            KategoriLista = new List<Kategori>();
            
        }

        public List<Kategori> HamtaAlla()
        {
            KategoriLista = GeneriskSerialiserare.Deserialisera();
            return KategoriLista;
        }

        public Kategori HamtaMedNamn(string namn)
        {
            Kategori kategori = null;

            foreach (Kategori objekt in GeneriskSerialiserare.Deserialisera())
            {
                if (objekt.Namn.Equals(namn))
                {
                    kategori = objekt;
                }
            }

            return kategori;
        }


        public void LaggTill(Kategori kategori)
        {
            
            KategoriLista.Add(kategori);
            Spara();
        }

        public void Uppdatera(int index, Kategori uppdateradKategori)
        {
            if (index >= 0)
            {
                
                KategoriLista[index] = uppdateradKategori;
                Spara();
            }
            Spara();
        }

        public void Radera(int index)
        {
            KategoriLista.RemoveAt(index);
            Spara();
        }

        public void Spara()
        {
            GeneriskSerialiserare.Serialisera(KategoriLista);
        }
    }
}
