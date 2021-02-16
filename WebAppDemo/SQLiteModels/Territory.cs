using System;
using System.Collections.Generic;

#nullable disable

namespace WebAppDemo.SQLiteModels
{
    public partial class Territory
    {
        public string TerritoryId { get; set; }
        public string TerritoryDescription { get; set; }
        public long RegionId { get; set; }
    }
}
