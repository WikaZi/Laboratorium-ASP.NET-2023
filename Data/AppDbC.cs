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
            string ADMIN_ID = Guid.NewGuid().ToString();
            string ROLE_ID = Guid.NewGuid().ToString();

            
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Name = "admin",
                NormalizedName = "ADMIN",
                Id = ROLE_ID,
                ConcurrencyStamp = ROLE_ID
            });

            
            var admin = new IdentityUser
            {
                Id = ADMIN_ID,
                Email = "wika@wiw.pl",
                EmailConfirmed = true,
                UserName = "wika",
                NormalizedUserName = "ADMIN"
            };

            
            PasswordHasher<IdentityUser> ph = new PasswordHasher<IdentityUser>();
            admin.PasswordHash = ph.HashPassword(admin, "1234Abcd$!");

           
            modelBuilder.Entity<IdentityUser>().HasData(admin);

            
            modelBuilder.Entity<IdentityUserRole<string>>()
            .HasData(new IdentityUserRole<string>
            {
                RoleId = ROLE_ID,
                UserId = ADMIN_ID
            });

            


            string USER_ID = Guid.NewGuid().ToString();
            string USER_ROLE_ID = Guid.NewGuid().ToString();

            
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Name = "user",
                NormalizedName = "USER",
                Id = USER_ROLE_ID,
                ConcurrencyStamp = USER_ROLE_ID
            });

            
            var user = new IdentityUser
            {
                Id = USER_ID,
                Email = "ola@wiw.pl",
                EmailConfirmed = true,
                UserName = "ola",
                NormalizedUserName = "USER"
            };

            
            PasswordHasher<IdentityUser> phUser = new PasswordHasher<IdentityUser>();
            user.PasswordHash = phUser.HashPassword(user, "ABC1234@#");

            
            modelBuilder.Entity<IdentityUser>().HasData(user);

            
            modelBuilder.Entity<IdentityUserRole<string>>()
            .HasData(new IdentityUserRole<string>
            {
                RoleId = USER_ROLE_ID,
                UserId = USER_ID
            });
           
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
