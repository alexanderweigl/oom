using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Opfer:Person,iAdresse
    {
        private Adresse anschrift;

        public Adresse Anschrift { get { return anschrift; } set { } }

        public Opfer(string vorname, string nachname, Adresse anschrift):base(vorname, nachname)
        {
            this.anschrift = anschrift;
        }
        /// <summary>
        /// Interface Implementierung
        /// </summary>
        /// <returns>anschrift</returns>
        public Adresse GetAdresse()
        {
            return anschrift;
        }
    }
}
