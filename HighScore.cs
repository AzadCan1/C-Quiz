using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    public class HighScore
    {
        private int hsNr;
        private string hsName;
        private int hsPunkte;

        public int HsNr { get => hsNr; set => hsNr = value; }
        public string HsName { get => hsName; set => hsName = value; }
        public int HsPunkte { get => hsPunkte; set => hsPunkte = value; }

        public HighScore(int hsNr, string hsName, int hsPunkte)
        {
            HsNr = hsNr;
            HsName = hsName;
            HsPunkte = hsPunkte; 
        }
    }
}
