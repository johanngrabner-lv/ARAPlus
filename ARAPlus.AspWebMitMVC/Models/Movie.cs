using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ARAPlus.AspWebMitMVC.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        [MinLength(2)]
        public string Genre { get; set; }
        public decimal Price { get; set; }
        public string Rating { get; set; }

        public string Demo { get; set; }
    }
}
