using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel.Syndication;
using System.Xml;
using System.Reflection.PortableExecutable;

namespace DAL
{
    public static class XmlHanterare
    {




        //public async static SyndicationFeed hamtaUrl(string sokUrl)
        //{
        //    XmlReader urlLasare = XmlReader.Create(sokUrl);
        //    SyndicationFeed feed = await SyndicationFeed.Load(urlLasare);


        //    return feed;
        //}

        public static async Task<SyndicationFeed> HamtaUrl(string sokUrl)
        {
            using (XmlReader urlLasare = XmlReader.Create(sokUrl))
            {
                SyndicationFeed feed = await Task.Run(() => SyndicationFeed.Load(urlLasare));
                return feed;
            }
        }



    }
}
