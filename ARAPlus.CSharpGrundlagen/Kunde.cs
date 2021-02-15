using System;
using System.Collections.Generic;
using System.Text;

namespace ARAPlus.CSharpGrundlagen
{
    class Kunde
    {
        public string Vorname { get; set; }

        public string Nachname { get; set; }

        //Default-Constructor
        public Kunde()
        {

        }
        public Kunde(string vorname)
        {
            this.Vorname = vorname;
        }
        public Kunde(string nachname, string vorname)
        {
            this.Vorname = vorname;
            this.Nachname = nachname;
        }

        public void SayHello()
        {
            Console.WriteLine($"Hello {Vorname}" );
        }
    }
}
