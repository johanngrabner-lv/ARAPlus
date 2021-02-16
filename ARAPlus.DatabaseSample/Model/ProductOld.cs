using System;
using System.Collections.Generic;
using System.Text;

namespace ARAPlus.DatabaseSample.Model
{
    class ProductOld
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int ProdId { get; set; }
        [System.ComponentModel.DataAnnotations.Required]
        public string Description { get; set; }
        public Category Category { get; set; }
    }

    class Category
    {
        public virtual ICollection<ProductOld> Products { get; set; }
    }
}
