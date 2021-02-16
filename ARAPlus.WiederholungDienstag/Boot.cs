using Grabner.Demo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARAPlus.WiederholungDienstag
{
    class Boot:Fahrzeug
    {
        public override void Beschleunigen()
        {
            Console.WriteLine("boot beschleunigt");
            AktuelleGeschwindigkeit +=2;
        }
    }
}
