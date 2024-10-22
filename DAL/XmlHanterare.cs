using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel.Syndication;
using System.Xml;

namespace DAL
{
    public static class XmlHanterare
    {
        //public XmlHanterare() {
            
        //}

       

        public static SyndicationFeed hamtaUrl(string sokUrl)
        {
            XmlReader urlLasare = XmlReader.Create(sokUrl);
            SyndicationFeed feed = SyndicationFeed.Load(urlLasare);


            return feed;
        }

    }
}
