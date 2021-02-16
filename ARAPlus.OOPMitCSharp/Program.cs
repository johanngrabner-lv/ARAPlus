using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace ARAPlus.OOPMitCSharp
{
    class Program
    {
        static void Main(string[] args)
        {

            Trace.Listeners.Add(new TextWriterTraceListener(
        File.CreateText(@"c:\workshops\log.txt")));
            Trace.AutoFlush = true;


            Debug.WriteLine("Hello from Debug");
            Trace.WriteLine("Hello from Debug");
            Trace.TraceInformation("Info");
            Trace.TraceError("Error");
            Trace.WriteLine("Hello World");
            


            Produkt produkt = new Produkt();
            produkt.Bezeichnung = "Handy";
            produkt.Preis = 120;

            var nettoPreis = produkt.CalcNettoPreis(abzug: 200, steuersatz: 10);

            int i = 12;
            Demo1(i);
            Demo2(produkt);

            Demo1ByRef(ref i);
            Demo2ByRef(ref produkt);

            int f;
            DemoOut( out f);

            int z;

            bool erfolgreich = int.TryParse("12", out z);

            Produkt pNeu = CreateProdukt(); //Fabriksmethoden

            int ergFunctionPlus = RechnenPlus(10, 20);

            int ergFunctionMinus = RechnenMinus(10, 20);

            MyCalcDelegate del1;

            del1 = RechnenPlus;

            int ergV1Del = Rechnen(del1, 10, 20);

            del1 = RechnenMinus;

            int ergV2Del = Rechnen(del1, 10, 20);

            //Lambdas

            int ergV3Del = Rechnen((k, l) => k + l,10,20);

            List<Produkt> meineProdukte = new List<Produkt>()
            {
                new Produkt(){ProduktId=1,Preis=200, Bezeichnung="Auto"},
                new Produkt(){ProduktId=2,Preis=700, Bezeichnung="Auto a2"},
                new Produkt(){ProduktId=3,Preis=900, Bezeichnung="Auto a3"},
            };

            var alleProdukteTeurerAls700MitDelegate = meineProdukte.Where(MySimpleWhere);
            var alleProdukteTeurerAls700MitLambda = meineProdukte.Where(einProdukt => pNeu.Preis >= 700);
            

            var alleDreier = meineProdukte.Where(pr => pr.Bezeichnung.Contains("A")).OrderBy(pr => pr.Preis);

        }

        public static bool MySimpleWhere(Produkt p)
        {
            return p.Preis > 700;
        }

        //Funktionszeiger auf int MethodenName(int, int)
        //Callback / Async, Events 
        public delegate int MyCalcDelegate(int a, int b);
        public static int Rechnen(MyCalcDelegate myLogic, int z1, int z2)
        {
            Console.WriteLine("Protokoll ");
            //Logik ausführen
            return myLogic(z1, z2);
        }

        public static int RechnenPlus(int z1, int z2)
        {
            return z1 + z2;
        }

        public static int RechnenMinus(int z1, int z2)
        {
            return z1 - z2;
        }


        public static Produkt CreateProdukt()
        {
            return new Produkt() { Bezeichnung = "Drucker" };
        }

        public static void DemoOut(out int x)
        {
            //x = x + 10;unassigned
            x = 50;

        }
        public static void Demo1ByRef(ref int j)
        {
            j = 17;
        }
        public static void Demo2ByRef(ref Produkt p)
        {
            p = new Produkt();
            p.Preis = 300;
        }

        public static void Demo1(int j) //byVal 
        {
            j = 17;
        }
        public static void Demo2(Produkt p)
        {
            p = new Produkt();
            p.Preis = 300;
        }
      

    }
}
