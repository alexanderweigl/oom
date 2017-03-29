using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Feuerwehr : iAdresse
    {
        private string name;
        private Adresse adresse;
        private List<Person> mitglieder;

        public string Name { get { return name; } set { } }
        public Adresse Adresse { get { return adresse; } }
        public List<Person> Mitglieder { get { return mitglieder; } }

        public Feuerwehr() { }
        [JsonConstructor]
        public Feuerwehr(string name, Adresse adresse)
        {
            this.name = name;
            this.adresse = adresse;
            mitglieder = new List<Person>();
        }
        /// <summary>
        /// Interface Implementierung
        /// </summary>
        /// <returns>adresse</returns>
        public Adresse GetAdresse()
        {
            return adresse;
        }
    }
}
