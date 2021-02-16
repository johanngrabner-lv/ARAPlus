using Grabner.Demo;
using System;
using Dienstag.DemoExtensions;
using System.Collections.Generic;
using System.Linq;

namespace ARAPlus.WiederholungDienstag
{
    class Program
    {
        static void Main(string[] args)
        {
            System.String s0 = "Hallo";
            String s1 = "Hello";
            string s2 = "World"; //alias für System.String in C#

            bool gleich = s1 == s2;

            System.Int32 i0 = 12;
            Int32 i1 = 12;
            int i2 = 12;

            Fahrzeug fBase = null;

            fBase = new Boot(); //upcast Boot->Fahrzeug
            fBase.Beschleunigen(); //? Boot
            fBase.Load(); //implizite Interface-Implementierung

            ((IPersistence)fBase).Save();


            Boot b = (Boot)fBase;//Downcast
            b.Beschleunigen();//?

            Point p1;
            p1.X = 20;
            p1.Y = 40;

            int benutzerEingabeInt = default(int);

            Console.WriteLine("Bitte geben Sie die PS ein");

            string eingabeBenutzer;

            eingabeBenutzer = Console.ReadLine();


            var warErfolgreich= int.TryParse(eingabeBenutzer, out benutzerEingabeInt);
            Fahrzeug fNeu = null;
            if (warErfolgreich)
            {
                fNeu = new Fahrzeug(benutzerEingabeInt);
            }

            try
            {
                benutzerEingabeInt = int.Parse(eingabeBenutzer);
                fNeu = new Fahrzeug(benutzerEingabeInt);
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Sie haben keine gültige Zahl eingegeben");
            }
            catch(OutOfMemoryException ex)
            {

            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                if (fNeu!=null)
                {
                    fNeu.Dispose();
                }
            }

            using(Fahrzeug fTemp =new Fahrzeug(1))
            {
                fTemp.Beschleunigen();
            } //Finally - Dispose



            Fahrzeug fMitEingabe = new Fahrzeug(benutzerEingabeInt);

            Fahrzeug f1 = new Fahrzeug();
            Fahrzeug f2 = new Fahrzeug(10);

            f1.Beschleunigen();

            f1.Bremsen(10);

            MeineErweiterungen.Bremsen(f1, 10);

            List<Fahrzeug> meineFahrzeuge = new List<Fahrzeug>()
            {
                new Fahrzeug(5){Marke="Seat" },
                new Fahrzeug(15){Marke="Seat" },
                new Fahrzeug(25){Marke="Audi" },
                new Fahrzeug(45){Marke="Mercedes" },

            };

            Console.WriteLine("Variante1\n");
            //Extension-Methoden
            var variante1Extension = meineFahrzeuge.Where(x => x.PS > 20)
                .OrderByDescending(x=>x.PS);
            foreach (var item in variante1Extension)
            {
                Console.WriteLine($"{item.PS}");
            }

            Fahrzeug fahrzeug = new();

            //SELECT PS, Marke FROM Fahrzeuge
            var variante2Linq = from p in meineFahrzeuge
                                where p.Marke == "Seat"
                                orderby p.PS
                                select new { Brand = p.Marke, Pferdestaerken = p.PS };

            Console.WriteLine("\nVariante2\n");
            foreach (var item in variante2Linq)
            {
                Console.WriteLine($"{item.Brand} {item.Pferdestaerken}");
            }





        }
    }
}
