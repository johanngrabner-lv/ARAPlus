using System;
using System.Collections.Generic;
using System.Linq;

namespace WiederholungMittwoch
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Person> meinePersonen = new List<Person>()
            {
                new Person(){Vorname="Andreas", Nachname="Mahr"},
                new Person(){Vorname="Claudia", Nachname="Fleck"},
                new Person(){Vorname="Ezgi", Nachname="Altug"}
            };

            var s = new SortiertNachVorname();
            meinePersonen.Sort(s);
            var vor = meinePersonen.OrderBy(p => p.Vorname);

            var vornamenSortiert = from v in meinePersonen
                                   orderby v.Vorname
                                   select v;

            System.Threading.Thread.CurrentThread.CurrentCulture =
                new System.Globalization.CultureInfo("de-AT");
            
            Console.WriteLine("Hello World!");
            Person p = new Person();
            
            Console.WriteLine(Person.MINIMUM_ALTER);
            p.Mittelname = "H";
            
            Console.WriteLine(p.Mittelname);

            ProgrammiererIn pro = new ProgrammiererIn();
            pro.EinTest(12);
            
            ((ILogic)pro).CalcGesamtPreis();
            ((IMittwoch)pro).CalcGesamtPreis();

            Func<int> myFunc = ((ILogic)pro).CalcGesamtPreis;
            int erg = myFunc();

            Action a = ((IMittwoch)pro).Ausgabe;
            a();

            bool castPossible1 = pro is Person;

            var person = pro as Person;

            if (person!=null)
            {
                //Cast hat funktioniert
            }
            
        }
    }
}
