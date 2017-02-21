using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Adresse
    {
        private int plz;
        private string stadt;
        private string straße;
        private int hausnummer;
        private int stiege;
        private int stock;
        private int tuer;

        public int PLZ { get { return plz; } set { } }
        public string Stadt { get { return stadt; } set { } }
        public string Straße { get { return straße; } set { } }
        public int Hausnummer { get { return hausnummer; } set { } }
        public int Stiege { get { return stiege; } set { } }
        public int Stock { get { return stock; } set { } }
        public int Tuer { get { return tuer; } set { } }

        public Adresse(int plz, string stadt, string straße, int hausnummer)
        {
            this.plz = plz;
            this.stadt = stadt;
            this.straße = straße;
            this.hausnummer = hausnummer;
        }
        public Adresse(int plz, string stadt, string straße, int hausnummer, int tuer)
        {
            this.plz = plz;
            this.stadt = stadt;
            this.straße = straße;
            this.hausnummer = hausnummer;
            this.tuer = tuer;
        }
        public Adresse(int plz, string stadt, string straße, int hausnummer, int stiege, int tuer)
        {
            this.plz = plz;
            this.stadt = stadt;
            this.straße = straße;
            this.hausnummer = hausnummer;
            this.stiege = stiege;
            this.tuer = tuer;
        }
        public Adresse(int plz, string stadt, string straße, int hausnummer, int stiege, int stock, int tuer)
        {
            this.plz = plz;
            this.stadt = stadt;
            this.straße = straße;
            this.hausnummer = hausnummer;
            this.tuer = tuer;
        }
    }
}
