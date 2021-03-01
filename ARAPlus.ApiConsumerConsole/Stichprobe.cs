using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ARAPlus.ApiConsumerConsole
{
    public class Stichprobe
    {
        public int StichprobeId { get; set; }
        [MinLength(2)]
        public string Name { get; set; }
        [Required]
        public DateTime Abgabedatum { get; set; }
        public bool Gefahrengut { get; set; }
        //public List<Detail> Details { get; set; }
    }
}
