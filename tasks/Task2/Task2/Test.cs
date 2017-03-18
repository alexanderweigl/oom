using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Task2
{
    [TestFixture]
    class Test
    {
        [Test]
        public void CreateAdresse()
        {
            Adresse a = new Adresse(1010, "Wien", "Am Hof", 1);

            Assert.IsTrue(a.PLZ == 1010);
            Assert.IsTrue(a.Stadt == "Wien");
            Assert.IsTrue(a.Straße == "Am Hof");
            Assert.IsTrue(a.Hausnummer == 1);
            Assert.IsTrue(a.Stock == 0);
            Assert.IsTrue(a.Stiege == 0);
            Assert.IsTrue(a.Tuer == 0); 
        }

        [Test]
        public void CreateMelder()
        {
            Melder d = new Melder("Thomas", "Huber", "+4366412345");

            Assert.IsTrue(d.Vorname == "Thomas");
            Assert.IsTrue(d.Nachname == "Huber");
            Assert.IsTrue(d.Telefonnummer == "+4366412345");
        }

        [Test]
        public void CreateOpfer()
        {
            Adresse a = new Adresse(1010, "Wien", "Am Hof", 1);
            Opfer f = new Opfer("Alexander", "Weigl", a);

            Assert.IsTrue(f.Vorname == "Alexander");
            Assert.IsTrue(f.Nachname == "Weigl");
            Assert.IsTrue(f.Anschrift.PLZ == 1010);
            Assert.IsTrue(f.Anschrift.Stadt == "Wien");
            Assert.IsTrue(f.Anschrift.Straße == "Am Hof");
            Assert.IsTrue(f.Anschrift.Hausnummer == 1);
        }

        [Test]
        public void CreateFeuerwehr()
        {
            Adresse a = new Adresse(1010, "Wien", "Am Hof", 1);
            Feuerwehr b = new Feuerwehr("Berufsfeuerwehr der Stadt Wien - HW", a);

            Assert.IsTrue(b.Name == "Berufsfeuerwehr der Stadt Wien - HW");
            Assert.IsTrue(b.GetAdresse() == a);
        }

        [Test]
        public void CreateEinsaetze()
        {
            Adresse a = new Adresse(1010, "Wien", "Am Hof", 1);
            Feuerwehr b = new Feuerwehr("Berufsfeuerwehr der Stadt Wien - HW", a);
            List<Feuerwehreinsatz> c = new List<Feuerwehreinsatz>();
            Melder d = new Melder("Thomas", "Huber", "+4366412345");

            c.Add(new Feuerwehreinsatz(a,d,"VU", b));

            Assert.IsTrue(c[0].Feuerwehren[0].Name == "Berufsfeuerwehr der Stadt Wien - HW");
            Assert.IsTrue(c[0].Feuerwehren[0] == b);
            Assert.IsTrue(c[0].GetAdresse() == a);
            Assert.IsTrue(c[0].Meldebild == "VU");
        }
        [Test]
        public void AddFeuerwehrToEinsatz()
        {
            Adresse a = new Adresse(1010, "Wien", "Am Hof", 1);
            Feuerwehr b = new Feuerwehr("Berufsfeuerwehr der Stadt Wien - HW", a);
            Feuerwehr e = new Feuerwehr("Feuerwehr Krems - HW", a);
            List<Feuerwehreinsatz> c = new List<Feuerwehreinsatz>();
            Melder d = new Melder("Thomas", "Huber", "+4366412345");

            c.Add(new Feuerwehreinsatz(a, d, "VU", b));

            c[0].AddFeuerwehr(e);

            Assert.IsTrue(c[0].Feuerwehren[1].Name == "Feuerwehr Krems - HW");
            Assert.IsTrue(c[0].Feuerwehren[1] == e);
        }

        [Test]
        public void AddEinsatz()
        {
            Adresse a = new Adresse(1010, "Wien", "Am Hof", 1);
            Feuerwehr b = new Feuerwehr("Berufsfeuerwehr der Stadt Wien - HW", a);
            Feuerwehr e = new Feuerwehr("Feuerwehr Krems - HW", a);
            List<Feuerwehreinsatz> c = new List<Feuerwehreinsatz>();
            Melder d = new Melder("Thomas", "Huber", "+4366412345");

            c.Add(new Feuerwehreinsatz(a, d, "VU", b));
            c.Add(new Feuerwehreinsatz(a, d, "Brand", b));

            Assert.IsTrue(c[1].Feuerwehren[0] == b);
            Assert.IsTrue(c[1].Meldebild == "Brand");
        }

        [Test]
        public void ExitEinsatz()
        {
            Adresse a = new Adresse(1010, "Wien", "Am Hof", 1);
            Feuerwehr b = new Feuerwehr("Berufsfeuerwehr der Stadt Wien - HW", a);
            List<Feuerwehreinsatz> c = new List<Feuerwehreinsatz>();
            Melder d = new Melder("Thomas", "Huber", "+4366412345");

            c.Add(new Feuerwehreinsatz(a, d, "VU", b));

            c[0].End();

            Assert.IsTrue(c[0].Ende != null);
        }
    }
}
