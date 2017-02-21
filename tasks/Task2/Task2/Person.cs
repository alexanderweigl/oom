using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Person
    {
        private string vorname, nachname;
        private Adresse anschrift;

        public string Vorname { get { return vorname; } set { } }
        public string Nachname { get { return nachname; } set { } }
        public Adresse Anschrift { get { return anschrift; } set { } }

        public Person() { }
        public Person(string vorname, string nachname)
        {
            this.vorname = vorname;
            this.nachname = nachname;
        }
        public Person(string vorname, string nachname, Adresse anschrift)
        {
            this.vorname = vorname;
            this.nachname = nachname;
            this.anschrift = anschrift;
        }
    }
}
