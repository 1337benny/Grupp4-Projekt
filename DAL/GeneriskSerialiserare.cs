using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DAL
{
    
    public class GeneriskSerialiserare<T>
    {
        public GeneriskSerialiserare(string filNamn) { 

        FilNamn = filNamn;

        }

        public string FilNamn { get; set; }


        public async Task Serialisera(List<T> enLista)
        {
            XmlSerializer serialiserare = new XmlSerializer(typeof(List<T>));
            await using (FileStream strom = new FileStream(FilNamn, FileMode.Create, FileAccess.Write, FileShare.None, 4096, useAsync: true))
            {
                serialiserare.Serialize(strom, enLista);
            }
        }

        



        public async Task<List<T>> Deserialisera()
        {
            if (!File.Exists(FilNamn))
            {
                return new List<T>();
            }

            XmlSerializer deserialiserare = new XmlSerializer(typeof(List<T>));
            await using (FileStream strom = new FileStream(FilNamn, FileMode.Open, FileAccess.Read, FileShare.Read, 4096, useAsync: true))
            {
                return (List<T>)deserialiserare.Deserialize(strom);
            }
        }

        

    }
}
