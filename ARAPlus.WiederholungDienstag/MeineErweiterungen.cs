using Grabner.Demo;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dienstag.DemoExtensions
{
    static class MeineErweiterungen
    {
        public static void Bremsen(this Fahrzeug fahrzeug, int minusGeschw)
        {
            fahrzeug.AktuelleGeschwindigkeit += minusGeschw;
        }
    }
}
