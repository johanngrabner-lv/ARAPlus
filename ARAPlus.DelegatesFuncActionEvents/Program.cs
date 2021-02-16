using System;
using System.Collections.Generic;
using MyNamespace;
using System.Linq;

namespace ARAPlus.DelegatesFuncActionEvents
{
    class Program
    {
        delegate void Del1();
        delegate void Del2(string s);

        //EventHandler
        public static void LagerUeberschritten(string aktuellerLagestand)
        {
            Console.WriteLine(aktuellerLagestand);
        }
        static void Main(string[] args)
        {
            List<Lager> lager = new List<Lager>();
            var ergebnisLager100 = lager.Where(l => l.Lagerbestand > 100);
            

            Lager l1 = new Lager();
            l1.OnLagerUberschritten += LagerUeberschritten;
            //l1.EventLagerUeberschritten += LagerUeberschritten;
            l1.AddToLager(70); //70
            //if (l1.Lagerbestand>100)
            l1.AddToLager(30); //100
            //if (l1.Lagerbestand > 100)
             l1.AddToLager(20); //120
            //if (l1.Lagerbestand > 100)
            l1.Print();

            IPrintable iPrint = l1;
            iPrint.Print();

            l1.GetLagerwert(12);
            //l1.Release();
            //l1.Close();
            //l1.Kill();
            l1.Dispose();
            l1 = null; //Garbage -- GC

            //Temp Resource-Usage-Pattern
            using (Lager l=new Lager())
            {
                l.Lagerbestand = 120;
                l.AddToLager(20);
            }//Dispose in einem finally-Block

            if (iPrint is Lager)
            { 
                Lager lager =(Lager) iPrint;
            }


            //Direkter Aufruf
            M1();

            //Delegate, FunctionPoint
            Del1 d = M1;
            d();

            Del2 d2 = M4;
            d2("Johann");

            //Generische Delegates Func mit Return, Action void

            Action a1 = M1;
            a1();

            Action<string> a2 = M4;
            a2("Johann");

            Func<string, int> f = M3;

            var erg = f("Hans");
           
        }

        public static void M1()
        {
            Console.WriteLine("M1");
        }

        public static void M2()
        {
            Console.WriteLine("M2");
        }

        public static void M4(string firstname)
        {
            Console.WriteLine($"Hello {firstname}");
        }

        public static int M3(string einText)
        {
            return einText.Length;
        }
    }
}
