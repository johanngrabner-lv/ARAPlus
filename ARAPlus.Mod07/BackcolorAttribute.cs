using System;
using System.Collections.Generic;
using System.Text;

namespace ARAPlus.Mod07
{
    [AttributeUsage(AttributeTargets.Class)]
    class BackcolorAttribute:Attribute
    {
        public string Farbe { get; set; }
        public BackcolorAttribute(string farbe)
        {
            Farbe = farbe;
        }

    }
}
