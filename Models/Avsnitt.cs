using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Avsnitt
    {

        public Avsnitt() { }
        
        public Avsnitt(string titel, string beskrivning) {
            if (!string.IsNullOrWhiteSpace(titel))
            {
                Titel = titel;
            }
            else
            {
                Titel = "Ingen titel finns";
            }

            if (!string.IsNullOrWhiteSpace(beskrivning))
            {
                Beskrivning = beskrivning;
            }
            else
            {
                Beskrivning = "Ingen beskrivning finns";
            }
            
        
        }

        public string Titel {  get; set; }
        public string Beskrivning { get; set; }
    }
}
