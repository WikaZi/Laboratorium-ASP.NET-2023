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
        public DbSet<SoftwareEntity> Softwares { get; set; }
        
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
                UserName = "adam",
                NormalizedUserName = "ADAM",
                Email = "adam@wsei.pl",
                NormalizedEmail = "ADAM@WSEI.PL",
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
            adminRole.ConcurrencyStamp =adminRole.Id;
            modelBuilder.Entity<IdentityRole>()
             .HasData(adminRole);
            

            modelBuilder.Entity<IdentityUserRole<string>>()
                .HasData(
                new IdentityUserRole<string>()
                {
                    RoleId = adminRole.Id,
                    UserId = user.Id
                }
                );
            var user1 = new IdentityUser()
            {
                Id = Guid.NewGuid().ToString(),
                UserName = "wika",
                NormalizedUserName = "WIKA",
                Email = "wika@wsei.pl",
                NormalizedEmail = "WIKA@WSEI.PL",
                EmailConfirmed = true,
            };
            PasswordHasher<IdentityUser> ph = new PasswordHasher<IdentityUser>();
            user1.PasswordHash = ph.HashPassword(user1, "1234Abcd$!");
            modelBuilder.Entity<IdentityUser>()
                .HasData(user1);

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
                    UserId = user1.Id
                }
                );



            modelBuilder.Entity<SoftwareEntity>().HasData(
                new SoftwareEntity()
                {
                    Id = 1,
                    Name = "Microsoft Office",
                    Version = "365"
                },
                new SoftwareEntity()
                {
                    Id = 2,
                    Name = "Windows 10",
                    Version = "20H2"
                },
                new SoftwareEntity()
                {
                    Id = 3,
                    Name = "Visual Studio Code",
                    Version = "1.50.1"
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
                    DateOfProduction = DateTime.Parse("2023-12-10"),
                    SoftwareId = 1
                },
                new ComputerEntity()
                {
                    Id = 223,
                    Name = "POW3R-HUGE",
                    Processor = "i9-11900K",
                    Memory = "64GB",
                    GraphicsCard = "RTX-4070",
                    Producer = "MAVIS-PR",
                    DateOfProduction = DateTime.Parse("2023-12-12"),
                    SoftwareId = 2

                }
              );
            modelBuilder.Entity<SoftwareLicenseEntity>().HasData(
                new SoftwareLicenseEntity
                {
                    Id = 1,
                    LicenseKey = "ABAB1212",
                    ExpirationDate = DateTime.Now.AddYears(1),
                    LicenseType = "Bussiness",
                    ComputerId = 123,
                    SoftwareId = 1
                },
                new SoftwareLicenseEntity()
                {
                    Id = 2,
                    LicenseKey = "MI45-L",
                    ExpirationDate = DateTime.Now.AddMonths(6),
                    LicenseType = "Home",
                    ComputerId = 223,
                    SoftwareId = 2,
                }

                );
                modelBuilder.Entity<SoftwareEntity>()
                    .HasMany(s => s.Computers)
                    .WithMany(c => c.Softwares)
                    .UsingEntity(j => j
                    .HasData(
                        new { SoftwaresId = 1, ComputersId = 123 },
                        new { SoftwaresId = 2, ComputersId = 223 }
                            ));

        }
    }
}
