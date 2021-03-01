using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ARAPlus.AspWebMitMVC.Models
{
    public class Stichprobe
    {
        public int StichprobeId { get; set; }
        [MinLength(2)]
        public string Name { get; set; }
        [Required]
        public DateTime Abgabedatum { get; set; }
        public bool Gefahrengut { get; set; }
    }
}
