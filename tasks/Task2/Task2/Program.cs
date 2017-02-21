using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Feuerwehreinsatz einsatz = new Feuerwehreinsatz("Wien", 2);

            Console.WriteLine("Einsatzort: " + einsatz.GetOrt());
            Console.WriteLine("Alarmstufe: " + einsatz.GetAlarmstufe());

            einsatz.UpdateAlarmstufe(3);

            Console.WriteLine("Alarmstufe: " + einsatz.GetAlarmstufe());
        }
    }
}
