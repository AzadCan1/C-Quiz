using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    public class Spieler
    {
        private int spNr;
        private string spName;
        private int spPass;

        public int SpNr { get => spNr; set => spNr = value; }
        public string SpName { get => spName; set => spName = value; }
        public int SpPass { get => spPass; set => spPass = value; }

        public Spieler( int spNr, string spName, int spPass)
        {
            SpNr = spNr;    
            SpName = spName;
            SpPass = spPass;

        }
    }
}
