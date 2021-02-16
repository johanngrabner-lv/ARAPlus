using ARAPlus.Mod06DLL;
using System;
using System.Collections.Generic;

namespace ARAPlus.Mod06ConsoleApp
{

    class ProductIdComplex
    {
        public string Shortcut { get; set; }
        public int CountryNumber { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            TeilnehmerIn t1 = new TeilnehmerIn();
            t1.ID = 1;
            t1.Vorname = "Claudia";
            t1.Geschlecht = Geschlecht.Frau;
            t1.Geschlecht = (Geschlecht)1;
            Console.WriteLine($"Hello {t1.Vorname} ToString: {t1}");

            (string, int) meineWerte = t1.GetInfo();
            Console.WriteLine(meineWerte.Item1);

            (string vorname, int nr) meineWerteV2 = t1.GetInfo();
            Console.WriteLine(meineWerteV2.vorname);

            var geschl = (Geschlecht)Enum.Parse(typeof(Geschlecht), "Mann");

            t1.Lieblingswetter = Wetter.Sonnig | Wetter.Warm | Wetter.Regnerisch;
            Console.WriteLine(t1.Lieblingswetter);

            Product<int> pInt = new Product<int>();
            pInt.ID = 12;

            Product<string> pString = new Product<string>();
            pString.ID = "Hello.World";

            Product<ProductIdComplex> pComplex = new Product<ProductIdComplex>();
            pComplex.ID = new ProductIdComplex();
            pComplex.ID.CountryNumber = 40;
            pComplex.ID.Shortcut = "AT";

            List<TeilnehmerIn> meineTeilnehmerInnen = new List<TeilnehmerIn>();
            meineTeilnehmerInnen.Add(new TeilnehmerIn() { ID = 12, Geschlecht = Geschlecht.Frau });
            
            List<string> meineTexte = new List<string>();
            meineTexte.Add("A");
            meineTexte.Add("C");

            int[] zahlen = new int[7];
          

            List<Product<string>> meineProdukte = new List<Product<string>>();
            meineProdukte.Add(new Product<string>() { ID = "Hello.World" });

            var pr1 = meineProdukte[0];

            Rechteck r1 = new Rechteck();
            r1.Laenge = 20;
            var l = r1[0];

            Rechteck r2 = new Rechteck();
            string s1 = "Hello", s2 = "World";
            string gesamt = s1 + s2;

            //var neuesRechteck = r1 + r2;

        }
    }
}
