using System;
using System.Collections.Generic;
using System.Text;

namespace ARAPlus.Mod06DLL
{
    //Custom
    public partial class Rechteck
    {
        public int Laenge { get; set; }
        public int Breite { get; set; }

        
        public int this[int index]
        {
            get {
                if (index == 0)
                    return Laenge;
                else
                    return Breite;
                }
            
        }

    }
}
