﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Feuerwehreinsatz:iAdresse
    {
        private Adresse ort;
        private DateTime beginn;
        private DateTime ende;
        private Melder melder;
        private List<Opfer> beteiligte;
        private int alarmstufe;
        private string meldebild;
        private List<Feuerwehr> feuerwehren;

        public Adresse Ort { get { return ort; } }
        public DateTime Beginn { get { return beginn; } }
        public DateTime Ende { get { return ende; } }
        public Melder Melder { get { return melder; } }
        public List<Opfer> Beteiligte { get { return beteiligte; } }
        public int Alarmstufe { get { return alarmstufe; } }
        public string Meldebild { get { return meldebild; } }
        public List<Feuerwehr> Feuerwehren { get { return feuerwehren; } }

        [JsonConstructor]
        public Feuerwehreinsatz(Adresse ort, DateTime beginn, DateTime ende, Melder melder, List<Opfer> beteiligte, int alarmstufe, string meldebild, List<Feuerwehr> feuerwehren)
        {
            this.ort = ort;
            this.beginn = beginn;
            this.ende = ende;
            this.melder = melder;
            this.beteiligte = beteiligte;
            this.alarmstufe = alarmstufe;
            this.meldebild = meldebild;
            this.feuerwehren = feuerwehren;
        }
        /// <summary>
        /// Erstellt einen neuen Einsatz mit einer Feuerwehr
        /// </summary>
        /// <param name="ort"></param>
        /// <param name="melder"></param>
        /// <param name="meldebild"></param>
        /// <param name="feuerwehr"></param>
        public Feuerwehreinsatz(Adresse ort, Melder melder, string meldebild, Feuerwehr feuerwehr)
        {
            this.beginn = DateTime.Now;
            this.ort = ort;
            this.melder = melder;
            this.meldebild = meldebild;
            this.alarmstufe = 1;
            this.feuerwehren = new List<Feuerwehr>();
            this.feuerwehren.Add(feuerwehr);
        }
        /// <summary>
        /// Fügt beteiligte Personen am Unfall hinzu
        /// </summary>
        /// <param name="beteiligte"></param>
        public void BeteiligtenHinzu(Opfer beteiligte)
        {
            if(this.beteiligte == null)
                this.beteiligte = new List<Opfer>();

            this.beteiligte.Add(beteiligte);
        }
        /// <summary>
        /// Beendet den Einsatz
        /// </summary>
        public void End()
        {
            this.ende = DateTime.Now;
        }
        /// <summary>
        /// Fügt Feuerwehr zum Einsatz hinzu
        /// </summary>
        /// <param name="feuerwehr"></param>
        public void AddFeuerwehr(Feuerwehr feuerwehr)
        {
            feuerwehren.Add(feuerwehr);
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
            tmp += $"Einsatzort: {ort}\nMelder: {melder.Vorname} {melder.Nachname} ({melder.Telefonnummer})";
            
            if(beteiligte != null)
            {
                tmp += "\n\nBeteiligte:\n";
                foreach (Opfer x in beteiligte)
                {
                    tmp += $"{x.Vorname} {x.Nachname}";

                    if (x.Anschrift != null)
                        tmp += $" - {ort}\n";
                    else
                        tmp += "\n";
                }
            }

            return tmp;
        }
        /// <summary>
        /// Interface Implementierung
        /// </summary>
        /// <returns>ort</returns>
        public Adresse GetAdresse()
        {
            return ort;
        }
    }
}
