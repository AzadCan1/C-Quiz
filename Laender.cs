using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    public class Laender
    {
        private int lNr;
        private string lName;
        private string lHauptstadt;
        private string lKontinent;

        public int LNr { get => lNr; set => lNr = value; }
        public string LName { get => lName; set => lName = value; }
        public string LHauptstadt { get => lHauptstadt; set => lHauptstadt = value; }
        public string LKontinent { get => lKontinent; set => lKontinent = value; }

        public Laender(int lnr, string lName, string lHauptstadt, string lKontinent)
        { 
          LNr = lnr;
          LName = lName;
          LHauptstadt = lHauptstadt;
          LKontinent = lKontinent;
        }
    }
}
