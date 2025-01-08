using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    public class Antworten
    {
        private int antnr;
        private int frnr;
        private string antwortText;
        private bool istKorrekt;

        public int Antnr { get => antnr; set => antnr = value; }
        public int Frnr { get => frnr; set => frnr = value; }
        public string AntwortText { get => antwortText; set => antwortText = value; }
        public bool IstKorrekt { get => istKorrekt; set => istKorrekt = value; }

        public Antworten(int antnr, int frnr, string antwortText, bool istKorrekt)
        {
            Antnr = antnr;
            Frnr = frnr;
            AntwortText = antwortText;
            IstKorrekt = istKorrekt; 
        }
    }
}
