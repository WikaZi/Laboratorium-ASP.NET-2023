using Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<ContactEntity> Contacts { get; set; }
        public DbSet<OrganizationEntity> Organizations { get; set; }
        private string DbPath { get; set; }
        public AppDbContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "contacts.db");
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options) =>
        options.UseSqlite($"Data Source={DbPath}");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ContactEntity>()
                .HasOne(c => c.Organization)
                .WithMany(O => O.Contacts)
                .HasForeignKey(c => c.OrganizationId);
            modelBuilder.Entity<OrganizationEntity>()
                .HasData(
                new OrganizationEntity()
                {
                    Id = 101,
                    Name = "WSEI",
                    Description = "Uczelnia wyższa"
                },
                new OrganizationEntity()
                {
                    Id = 102,
                    Name = "Comarch",
                    Description = "Przedsiębiorstwo IT"
                }
                ) ;

            modelBuilder.Entity<ContactEntity>().HasData(
                new ContactEntity() 
                {   Id = 1,
                    Name = "Adam",
                    Email = "adam@wsei.edu.pl",
                    Phone = "127813268163",
                    Birth = new DateTime(2000, 10, 10), 
                    OrganizationId = 101, },
                new ContactEntity() 
                { Id = 2,
                    Name = "Ewa",
                    Email = "ewa@wsei.edu.pl",
                    Phone = "293443823478",
                    Birth = new DateTime(1999, 8, 10),
                    OrganizationId = 102,  },
                new ContactEntity()
                { Id = 3,
                    Name = "Wika",
                    Email = "wwiw@wsei.edu.pl",
                    Phone = "23443823478",
                    Birth = new DateTime(2005, 8, 10) }

            ) ;
            modelBuilder.Entity<OrganizationEntity>()
                .OwnsOne(o => o.Address)
                .HasData(
                    new
                    {
                        OrganizationEntityId = 101,
                        City = "Kraków",
                        Street = "św.Filipa 17",
                        PostalCode = "31-150"
                    },
                    new 
                    {
                        OrganizationEntityId = 102,
                        City = "Kraków",
                        Street = "Rozwoju 1/4",
                        PostalCode = "36-160"
                    }

                );
        }

    }
}
