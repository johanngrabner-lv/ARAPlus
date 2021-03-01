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
        public StichprobenContext()
        {

        }

        public DbSet<Stichprobe> Stichprobe { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
          
                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=StichprobenDB;Trusted_Connection=True;MultipleActiveResultSets=true");
          
        }
    }
}
