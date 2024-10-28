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
            if (titel != null)
            {
                Titel = titel;
            }
            else
            {
                Titel = "Okänt avsnitt-titel";
            }
            if (beskrivning != null)
            {
                Beskrivning = beskrivning;
            }
            else
            {
                Beskrivning = "Okänd beskrivning";
            }
            
        
        }

        public string Titel {  get; set; }
        public string Beskrivning { get; set; }
    }
}
