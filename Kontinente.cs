using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    public class Kontinente
    {
        private int kNr;
        private string kName;

        public int KNr { get => kNr; set => kNr = value; }
        public string KName { get => kName; set => kName = value; }

        public Kontinente(int KNr, String KName) 
        {
            KNr = kNr;
            KName = kName;
        } 
    }
}
