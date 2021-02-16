using System;
using System.Collections.Generic;

#nullable disable

namespace ARAPlus.DatabaseSample
{
    //POCO
    public partial class Shipper
    {
        public Shipper()
        {
            Orders = new HashSet<Order>();
        }

        [System.ComponentModel.DataAnnotations.Key]
        public long ShipperId { get; set; }
        [System.ComponentModel.DataAnnotations.Required]
        public string CompanyName { get; set; }
        public string Phone { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
