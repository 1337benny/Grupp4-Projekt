using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Syndication;
using System.Xml;

namespace Grupp4_Projekt
{
    public class Test
    {

        public Test() { }
        public void TestMetod() {
            XmlReader reader = XmlReader.Create("https://feeds.acast.com/public/shows/66b63f9d5f2de2802ac88892");
            SyndicationFeed feed = SyndicationFeed.Load(reader);

        }


    }
}
