using Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Data
{
    public class AppDbC : DbContext
    {
        public DbSet<ComputerEntity> Computers { get; set; }
        private string DbPath { get; set; }
        public AppDbC()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "computers.db");
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options) =>
        options.UseSqlite($"Data Source={DbPath}");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ComputerEntity>().HasData(
                new ComputerEntity()
                {
                    Id = 1,
                    Name = "G4MR-HERO",
                    Processor = "i7-13700F",
                    Memory = "32GB",
                    GraphicsCard = "RTX-4060Ti",
                    Producer = "6253efvdfEr2",
                    DateOfProduction = DateTime.Parse("2023-12-10")
                }
              );
        }
    }
}
