using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    public class Fragen
    {
        private int fnr;
        private int lnr;
        private string frText;
        private string typ;

        public int FNr { get => fnr; set => fnr = value; }
        public int LNr { get => lnr; set => lnr = value; }
        public string FrText { get => frText; set => frText = value; }
        public string Typ { get => typ; set => typ = value; }

        public Fragen( int frnr, int lnr, string frText, string typ )
        {
            FNr = frnr;
            LNr = lnr;
            FrText = frText;
            Typ = typ;
        }
    }
}
