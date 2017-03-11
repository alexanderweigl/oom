using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Feuerwehreinsatz> einsaetze = new List<Feuerwehreinsatz>();

            Feuerwehr feuerwehr_wien_hw = new Feuerwehr("Berufsfeuerwehr der Stadt Wien - HW", new Adresse(1010, "Wien", "Am Hof", 1));
            Feuerwehr feuerwehr_wien_15 = new Feuerwehr("Berufsfeuerwehr der Stadt Wien - Wache 15", new Adresse(1150, "Wien", "Gumpendorfer Gürtel", 143));

            einsaetze.Add(new Feuerwehreinsatz(new Adresse(1150, "Wien","Kranzgasse", 11, 1, 8),new Melder("Thomas", "Huber", "+4366412345"), "Verkehrsunfall", feuerwehr_wien_15));
            Melder a = new Melder("Alexander", "Weigl", "+4368012345");
            einsaetze.Add(new Feuerwehreinsatz(new Adresse(1120, "Wien", "Tivoligasse", 13), a, "Menschenrettung", feuerwehr_wien_hw));

            Opfer opfer1 = new Opfer("Stefanie", "Herz", new Adresse(3562, "Mollands", "Weinstraße", 16));
            einsaetze[0].BeteiligtenHinzu(opfer1);


            foreach (Feuerwehreinsatz x in einsaetze)
            {
                Console.WriteLine($"---\n{x}\n---");
            }


            Console.WriteLine("Beteiligte werden hinzugefügt und der 2. Einsatz wird beendet...");
            Thread.Sleep(3000);
            Console.Clear();

            Opfer opfer2 = new Opfer("Raphael", "Weigl", new Adresse(3524, "Gloden", "Gloden", 34));
            einsaetze[1].BeteiligtenHinzu(opfer2);

            Opfer opfer3 = new Opfer("Alexander", "Weigl", new Adresse(1150, "Wien", "Kranzgasse", 11, 1, 1, 8));
            einsaetze[0].BeteiligtenHinzu(opfer3);

            einsaetze[1].Ende();

            foreach (Feuerwehreinsatz x in einsaetze)
            {
                Console.WriteLine($"---\n{x}\n---");
            }

            Console.WriteLine("\nEingesetzte Feuerwehrn:");

            foreach (Feuerwehreinsatz fe in einsaetze)
            {
                foreach (Feuerwehr f in fe.Feuerwehrwehren)
                {
                    Console.WriteLine(f.Name);
                }
            }

            var iAdresse_array = new iAdresse[] { einsaetze[0], opfer1, opfer2, einsaetze[1], feuerwehr_wien_15, feuerwehr_wien_hw };

            Console.WriteLine("\nAdressen:");

            foreach (var o in iAdresse_array)
            {
                Console.WriteLine(o.GetAdresse());
            }
        }
    }
}
