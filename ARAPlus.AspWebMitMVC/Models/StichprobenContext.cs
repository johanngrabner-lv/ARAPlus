using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ARAPlus.AspWebMitMVC.Models
{
    public class StichprobenContext : DbContext
    {
        public StichprobenContext(DbContextOptions<StichprobenContext> options)
            : base(options)
        {
        }

        public DbSet<Stichprobe> Stichprobe { get; set; }
    }
}
