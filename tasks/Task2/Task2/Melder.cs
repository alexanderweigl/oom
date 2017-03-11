using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Melder:Person
    {
        private string telefonnummer;

        public string Telefonnummer { get { return telefonnummer; } set { } }

        public Melder(string vorname, string nachname, string telefonnummer):base(vorname,nachname)
        {
            this.telefonnummer = telefonnummer;
        }
    }
}
