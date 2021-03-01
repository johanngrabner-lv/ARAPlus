using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ARAPlus.AspWebMitMVC.Models
{
    public class StichprobenViewModel
    {
        public List<Stichprobe> Stichproben { get; set; }

        public DateTime LetztAbgabe { get; set; }

        public int AnzahlGefahrengut { get; set; }
    }
}
