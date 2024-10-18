using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Grupp4_Projekt
{
    
    public class GeneriskSerialiserare<T>
    {
        public GeneriskSerialiserare(string filNamn) { 

        FilNamn = filNamn;

        }

        public string FilNamn { get; set; }

        //public void SerialiseraEttObjekt(T objekt)
        //{
        //    XmlSerializer serialiserare = new XmlSerializer(typeof(T));
        //    using (FileStream strom = new FileStream(FilNamn, FileMode.Append, FileAccess.Write))
        //    {
        //        serialiserare.Serialize(strom, objekt);
        //    }
        //}

        public void Serialisera(List<T> enLista)
        {
            XmlSerializer serialiserare = new XmlSerializer(typeof(List<T>));
            using (FileStream strom = new FileStream(FilNamn, FileMode.Create, FileAccess.Write)) // Ändrat till FileMode.Create
            {
                serialiserare.Serialize(strom, enLista);
            }
        }




        public List<T> Deserialisera()
        {
            if (!File.Exists(FilNamn)) // Kontrollera om filen finns
            {
                return new List<T>(); // Returnera en tom lista om filen inte finns
            }

            XmlSerializer deserialiserare = new XmlSerializer(typeof(List<T>));
            using (FileStream strom = new FileStream(FilNamn, FileMode.Open, FileAccess.Read))
            {
                return (List<T>)deserialiserare.Deserialize(strom); // Returnera deserialiserad lista
            }
        }



        //public List<T> DeserialiseraFranObjekt()
        //{
        //    List<T> nyLista = new List<T>();

        //    XmlSerializer deserialiserare = new XmlSerializer(typeof(T));
        //    using (FileStream strom = new FileStream(FilNamn, FileMode.Open, FileAccess.Read))
        //    {
        //        T objekt = (T)deserialiserare.Deserialize(strom);
        //        nyLista.Add(objekt);
        //    }

        //    return nyLista;
        //}
    }
}
