using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ARAPlus.AspWebMitMVC.Models
{
    public class Detail
    {
        public int DetailId { get; set; }
        public string Beschreibung { get; set; }

        public Stichprobe Stichprobe { get; set; }
    }
    public class Stichprobe
    {
        public int StichprobeId { get; set; }
        [MinLength(2)]
        public string Name { get; set; }
        [Required]
        public DateTime Abgabedatum { get; set; }
        public bool Gefahrengut { get; set; }
        public List<Detail> Details { get; set; }
    }
}
