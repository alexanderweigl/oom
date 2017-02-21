using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Feuerwehreinsatz
    {
        public string ort;
        public int alarmstufe;
        private string beteiligter;

        public Feuerwehreinsatz(string ort, int alarmstufe)
        {
            this.ort = ort;
            this.alarmstufe = alarmstufe;
        }

        public void UpdateAlarmstufe(int alarmstufe)
        {
            this.alarmstufe = alarmstufe;
        }
    }
}
