using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Feuerwehreinsatz
    {
        private string ort;
        private int alarmstufe;
        private string beteiligter;

        public Feuerwehreinsatz(string ort, int alarmstufe)
        {
            this.ort = ort;
            this.alarmstufe = alarmstufe;
        }

        public string GetOrt() => ort;
        public int GetAlarmstufe() => alarmstufe;

        public void UpdateAlarmstufe(int alarmstufe)
        {
            this.alarmstufe = alarmstufe;
        }
    }
}
