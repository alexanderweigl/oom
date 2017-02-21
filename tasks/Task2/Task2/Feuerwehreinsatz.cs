using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Feuerwehreinsatz
    {
        private Adresse ort;
        private DateTime beginn;
        private DateTime ende;
        private Person melder;
        private List<Person> beteiligte;
        private int alarmstufe;
        private string meldebild;

        /// <summary>
        /// Erstellt einen neuen Einsatz
        /// </summary>
        /// <param name="ort"></param>
        /// <param name="melder"></param>
        /// <param name="meldebild"></param>
        public Feuerwehreinsatz(Adresse ort, Person melder, string meldebild)
        {
            this.beginn = DateTime.Now;
            this.ort = ort;
            this.melder = melder;
            this.meldebild = meldebild;
            this.alarmstufe = 1;
        }
        /// <summary>
        /// Fügt beteiligte Personen am Unfall hinzu
        /// </summary>
        /// <param name="beteiligte"></param>
        public void BeteiligtenHinzu(Person beteiligte)
        {
            if(this.beteiligte == null)
                this.beteiligte = new List<Person>();

            this.beteiligte.Add(beteiligte);
        }
        /// <summary>
        /// Beendet den Einsatz
        /// </summary>
        public void Ende()
        {
            this.ende = DateTime.Now;
        }
        /// <summary>
        /// Methode konvertiert eine Adresse zu einem String mit Berücksichtigung der vorhanden Informationen
        /// </summary>
        /// <param name="ort"></param>
        /// <returns></returns>
        private string AnschriftToString(Adresse ort)
        {
            if ((ort.Stiege == 0) && (ort.Stock == 0) && (ort.Tuer == 0))
                return $"{ort.PLZ} {ort.Stadt}, {ort.Straße} {ort.Hausnummer}";
            else if ((ort.Stiege == 0) && (ort.Stock == 0))
                return $"{ort.PLZ} {ort.Stadt}, {ort.Straße} {ort.Hausnummer}/{ort.Tuer}";
            else
                return $"{ort.PLZ} {ort.Stadt}, {ort.Straße} {ort.Hausnummer}/{ort.Stiege}/{ort.Stock}/{ort.Tuer}";
        }
        /// <summary>
        /// Überschreibt die ToString-Methode zur einfachen Ausgabe in einer foreach-Schleife
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string tmp = $"Einsatz: {meldebild} - {alarmstufe}\nBeginn: {beginn}\n";
            if (ende != new DateTime())
                tmp += $"Ende: {ende}\n";
            tmp += $"Einsatzort: {AnschriftToString(ort)}\nMelder: {melder.Vorname} {melder.Nachname}";
            
            if(beteiligte != null)
            {
                tmp += "\n\nBeteiligte:\n";
                foreach (Person x in beteiligte)
                {
                    tmp += $"{x.Vorname} {x.Nachname}";

                    if (x.Anschrift != null)
                        tmp += $" - {AnschriftToString(x.Anschrift)}\n";
                    else
                        tmp += "\n";
                }
            }

            return tmp;
        }
    }
}
