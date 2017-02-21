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


            einsaetze.Add(new Feuerwehreinsatz(new Adresse(1150, "Wien","Kranzgasse", 11, 1, 8),new Person("Thomas", "Huber"), "Verkehrsunfall"));
            Person a = new Person("Alexander", "Weigl");
            einsaetze.Add(new Feuerwehreinsatz(new Adresse(1120, "Wien", "Tivoligasse", 13), a, "Menschenrettung"));

            einsaetze[0].BeteiligtenHinzu(new Person("Stefanie", "Herz", new Adresse(3562, "Mollands", "Weinstraße", 16)));


            foreach (Feuerwehreinsatz x in einsaetze)
            {
                Console.WriteLine($"---\n{x}\n---");
            }


            Console.WriteLine("Beteiligte werden hinzugefügt und der 2. Einsatz wird beendet...");
            Thread.Sleep(3000);
            Console.Clear();

            einsaetze[1].BeteiligtenHinzu(new Person("Raphael", "Weigl", new Adresse(3524, "Gloden", "Gloden", 34)));
            einsaetze[0].BeteiligtenHinzu(a);
            einsaetze[1].Ende();

            foreach (Feuerwehreinsatz x in einsaetze)
            {
                Console.WriteLine($"---\n{x}\n---");
            }
        }
    }
}
