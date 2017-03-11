using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    abstract class Person
    {
        private string vorname, nachname;

        public string Vorname { get { return vorname; } set { } }
        public string Nachname { get { return nachname; } set { } }

        public Person() { }

        /// <summary>
        /// Erstellt eine neue Person
        /// </summary>
        /// <param name="vorname"></param>
        /// <param name="nachname"></param>
        public Person(string vorname, string nachname)
        {
            this.vorname = vorname;
            this.nachname = nachname;
        }
    }
}
