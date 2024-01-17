using Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using SQLitePCL;

namespace Data
{
    public class AppDbC : IdentityDbContext<IdentityUser>
    {
        public DbSet<ComputerEntity> Computers { get; set; }
        //public DbSet<SoftwareEntity> Softwares { get; set; }
        
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

            base.OnModelCreating(modelBuilder);
            var user = new IdentityUser()
            {
                Id = Guid.NewGuid().ToString(),
                UserName = "wika",
                NormalizedUserName = "WIKA",
                Email = "wika@wsei.pl",
                NormalizedEmail = "WIKA@WSEI.PL",
                EmailConfirmed = true,
            };
            PasswordHasher<IdentityUser> passwordHasher = new PasswordHasher<IdentityUser>();
            user.PasswordHash = passwordHasher.HashPassword(user, "1234Abcd$");
            modelBuilder.Entity<IdentityUser>()
                .HasData(user);
            //towrzenie roli
            var adminRole = new IdentityRole()
            {
                Id = Guid.NewGuid().ToString(),
                Name = "admin",
                NormalizedName = "ADMIN"
            };
            adminRole.ConcurrencyStamp = adminRole.Id;
            modelBuilder.Entity<IdentityRole>()
             .HasData(adminRole);
            //skojarzenie uzytkownika

            modelBuilder.Entity<IdentityUserRole<string>>()
                .HasData(
                new IdentityUserRole<string>()
                {
                    RoleId = adminRole.Id,
                    UserId = user.Id
                }
                );

           
            var secondUser = new IdentityUser()
            {
                Id = Guid.NewGuid().ToString(),
                UserName = "nikola",
                NormalizedUserName = "NIKOLA",
                Email = "nikola@wsei.pl",
                NormalizedEmail = "NIKOLA@WSEI.PL",
                EmailConfirmed = true,
            };
            secondUser.PasswordHash = passwordHasher.HashPassword(secondUser, "5678Efgh$!!");
            modelBuilder.Entity<IdentityUser>()
                .HasData(secondUser);
            //towrzenie roli
            var userRole = new IdentityRole()
            {
                Id = Guid.NewGuid().ToString(),
                Name = "user",
                NormalizedName = "USER"
            };
            userRole.ConcurrencyStamp = userRole.Id;
            modelBuilder.Entity<IdentityRole>()
             .HasData(userRole);
            //skojarzenie uzytkownika

            modelBuilder.Entity<IdentityUserRole<string>>()
                .HasData(
                new IdentityUserRole<string>()
                {
                    RoleId = userRole.Id,
                    UserId = secondUser.Id
                }
                );


            modelBuilder.Entity<ComputerEntity>().HasData(
                new ComputerEntity()
                {
                    Id = 123,
                    Name = "G4MR-HERO",
                    Processor = "i7-13700F",
                    Memory = "32GB",
                    GraphicsCard = "RTX-4060Ti",
                    Producer = "6253efvdfEr2",
                    DateOfProduction = DateTime.Parse("2023-12-10")

                },
                new ComputerEntity()
                {
                    Id = 223,
                    Name = "POW3R-HUGE",
                    Processor = "i9-11900K",
                    Memory = "64GB",
                    GraphicsCard = "RTX-4070",
                    Producer = "MAVIS-PR",
                    DateOfProduction = DateTime.Parse("2023-12-12")


                },
                new ComputerEntity()
                {
                    Id = 22,
                    Name = "D3MOGA-23",
                    Processor = "i9-13700K",
                    Memory = "128GB",
                    GraphicsCard = "RTX-4060TI",
                    Producer = "XAMI",
                    DateOfProduction = DateTime.Parse("2013-12-13")
                }

              ) ;

           
        }
    }
}
