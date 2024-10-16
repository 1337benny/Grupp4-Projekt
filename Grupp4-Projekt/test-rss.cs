using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel.Syndication;
using System.Xml;
using System.Diagnostics;


namespace Grupp4_Projekt
{
    public class Test
    {

        public Test() { }
        public string TestMetod() {
            XmlReader reader = XmlReader.Create("https://api.sr.se/api/rss/program/2519");
            SyndicationFeed feed = SyndicationFeed.Load(reader);

            foreach (SyndicationItem item in feed.Items)
            {
                Debug.WriteLine("Title " + item.Title.Text);

                Debug.WriteLine("Summary: " + item.Summary.Text);
            }

            return ("Titel: " + feed.Title.Text);

       


        }


    }
}
