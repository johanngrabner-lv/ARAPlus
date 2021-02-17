﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace ARAPlus.DatabaseSample
{
    
    public partial class Order
    {
        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        [Key]
        public long OrderId { get; set; }
        public string CustomerId { get; set; }
        public long? EmployeeId { get; set; }
        public byte[] OrderDate { get; set; }
        public byte[] RequiredDate { get; set; }
        public byte[] ShippedDate { get; set; }
        public long? ShipVia { get; set; }
        public byte[] Freight { get; set; }

        
        public string ShipName { get; set; }
        public string ShipAddress { get; set; }
        public string ShipCity { get; set; }
        public string ShipRegion { get; set; }
        public string ShipPostalCode { get; set; }
        public string ShipCountry { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Shipper ShipViaNavigation { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
