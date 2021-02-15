using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using static System.Console;

namespace ARAPlus.CSharpGrundlagen
{


    class Program
    {
        public static int Test1()
        {
            return 2;
        }
        static void Main(string[] args)
        {
            int j1 = 12;
            int j2 = int.MaxValue;

            checked
            {
                int j3 = j1 + j2;
            }

            

            string eineZahlAlsText = "12";
            int eineZahl = int.Parse(eineZahlAlsText);

            bool trueOrNotV1 = 10 == 9 & 11 < 12;
            bool trueOrNotV2 = 10 == 9 && 11 < 12;
            bool trueOrNotV3 = 10 == 9 && Test1() == 2;



            int ergTest1 = Test1();
            bool trueOrNotV4 = 10 == 9 && ergTest1 == 2;
            


            Console.WriteLine($"Wochentag {args[0]} Menue: {args[1]}");
            System.Console.WriteLine("Full qualified");
            Console.WriteLine("Hallo - wie heißen Sie?");
            string benutzerEingabe = Console.ReadLine();
            WriteLine("Hello - möglich da ein static using vorhaden");

            Console.WriteLine($"Hello {benutzerEingabe}");


            Demo4DynamicVsObject();
            // double a = 0.1;
            //double b = 0.2;
            decimal a = 0.1M;
            decimal b = 0.2M;
            Console.WriteLine($"Ist gleich ? {a + b ==0.3M}");

                string fileNameV1 = "c:\\workshops\\helloARA.txt";
            string fileNameV2 = @"c:\workshops\helloARA.txt";

            File.Create(fileNameV1);

            Console.WriteLine($"Hello World! Max von int ist {int.MaxValue}");
            Demo1(); //Statistische Methoden über Klasse aufrufen
            Program.Demo1();

           Program p1 = new Program();
            //p1.Demo2();
            p1.Demo3();
            Demo5(12, 17);
            Demo5(wert2: 20, wert1: 40);
            Demo5(wert2: 20);
        }

        public static void Demo5(int wert1=7, int wert2=4)
        {

        }

        public static void Demo4DynamicVsObject()
        {

            Kunde kNull = null;
            kNull = new Kunde();


            //int eineZahl = null;
            Nullable<int> eineZahlV1 = null;
            int? eineZahlV2 = null;

            var isNullV1 = eineZahlV1.HasValue;

            if (eineZahlV1.HasValue==true)
            {
                int erg = eineZahlV1.Value * 10;
            }

            if (kNull!=null)
            {
                string nachn = kNull.Nachname;
            }

            string nachname = kNull?.Nachname;

            Kunde ku1 = new Kunde() { Nachname = "Grabner", Vorname = "Johann" };

            Kunde ku2 = new Kunde();
            ku2.Vorname = "Johann";
            ku2.Nachname = "Grabner";

            List<Kunde> meineKunden = new List<Kunde>()
            {
                new Kunde(){Vorname="Gerald",Nachname="Hoch"},
                new Kunde(){Vorname="Gregor", Nachname="Friedl"}
            };

            Kunde mahrAndreas = new Kunde();
            mahrAndreas.Vorname = "Andreas";
            mahrAndreas.Nachname = "Mahr";
            meineKunden.Add(mahrAndreas);

            Kunde ku3 = new Kunde("Johann");

            object o1 = new Kunde() { Vorname = "Johann" };
            //o1.SayHello();
            Kunde k1 = (Kunde)o1; //Casting kann zu einer Exception fürhen
            k1.SayHello();


            dynamic kunde = new Kunde() { Vorname = "Andreas" };
            kunde.SayHello();

            Kunde k2 = new Kunde();
            Kunde k3 = new(); //Featur C# - Projekteigenschaften ändern

            int i1 = 10;
            int i2 = default(int);

        }
        public void Demo3()
        {
            foreach (var r in Assembly.GetEntryAssembly()
  .GetReferencedAssemblies())
            {
                // load the assembly so we can read its details
                var a = Assembly.Load(new AssemblyName(r.FullName));
                // declare a variable to count the number of methods
                int methodCount = 0;
                // loop through all the types in the assembly
                foreach (var t in a.DefinedTypes)
                {
                    // add up the counts of methods
                    methodCount += t.GetMethods().Length;
                }
                // output the count of types and their methods
                Console.WriteLine(
                  "{0:N0} types with {1:N0} methods in {2} assembly.",
                  arg0: 10,
                  arg1: methodCount,
                  arg2: r.Name);
            }
        }
            public void Demo2() // Instanz-Methode
        {
            Console.WriteLine("hello von Demo2");
        }
        //Access modifier - public, private
        //Rückgabewert - int, void 
        //Namen
        /// <summary>
        /// Dokumentationskommentar
        /// </summary>
        public static void Demo1() //Klassenmethode - meisten bei Utility-Functions Math.Round, Console.WriteLine
        {
            /*
             * Mehrzeilig
             */

            int z1=20, z2 = 10;

            int ergebnisV1 = z1 + z2;
            var ergebnisV2 = z1 + z2;
            //var test = GetValue();
            System.Console.WriteLine("Hello ARAPlus");
            //cw -- 
            Console.WriteLine("Das Ergebnis ist " + ergebnisV1);
            Console.WriteLine($"Das Ergebnis aus der Addition von {z1} + {z2} = {ergebnisV1} ");

        }
    }
}
