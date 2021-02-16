using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace ARAPlus.DatabaseSample.Model
{
    class NorthwindContextOld : Microsoft.EntityFrameworkCore.DbContext
    {
        public DbSet<ProductOld> Products{ get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductOld>()
                .Property(p => p.Description)
                .IsRequired();

            
        }

        protected override void OnConfiguring(
      DbContextOptionsBuilder optionsBuilder)
        {
            string path= @"C:\Workshops\ARAPlus\Sqlite\Tools\sqlite-tools-win32-x86-3340100\Northwind.db";
            optionsBuilder.UseSqlite($"Filename={path}");
        }
    }
}
