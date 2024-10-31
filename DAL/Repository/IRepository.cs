using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DAL.Repository
{
    public interface IRepository<T>
    {

        List<T> HamtaAlla();
        T HamtaMedNamn(string namn);
        void LaggTill(T objekt);
        void Uppdatera(int index, T objekt);
        void Radera(int index);
        void Spara();
    }
}
