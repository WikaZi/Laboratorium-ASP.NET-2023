﻿// <auto-generated />
using System;
using Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Data.Migrations.AppDbCMigrations
{
    [DbContext(typeof(AppDbC))]
    [Migration("20240101194406_role")]
    partial class role
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.13");

            modelBuilder.Entity("ComputerEntitySoftwareEntity", b =>
                {
                    b.Property<int>("ComputersId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SoftwaresId")
                        .HasColumnType("INTEGER");

                    b.HasKey("ComputersId", "SoftwaresId");

                    b.HasIndex("SoftwaresId");

                    b.ToTable("ComputerEntitySoftwareEntity");

                    b.HasData(
                        new
                        {
                            ComputersId = 123,
                            SoftwaresId = 1
                        },
                        new
                        {
                            ComputersId = 223,
                            SoftwaresId = 2
                        });
                });

            modelBuilder.Entity("Data.Entities.ComputerEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateOfProduction")
                        .HasColumnType("TEXT");

                    b.Property<string>("GraphicsCard")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Memory")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Processor")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Producer")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("SoftwareId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Computers");

                    b.HasData(
                        new
                        {
                            Id = 123,
                            DateOfProduction = new DateTime(2023, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            GraphicsCard = "RTX-4060Ti",
                            Memory = "32GB",
                            Name = "G4MR-HERO",
                            Processor = "i7-13700F",
                            Producer = "6253efvdfEr2",
                            SoftwareId = 1
                        },
                        new
                        {
                            Id = 223,
                            DateOfProduction = new DateTime(2023, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            GraphicsCard = "RTX-4070",
                            Memory = "64GB",
                            Name = "POW3R-HUGE",
                            Processor = "i9-11900K",
                            Producer = "MAVIS-PR",
                            SoftwareId = 2
                        });
                });

            modelBuilder.Entity("Data.Entities.SoftwareEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Version")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Softwares");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Microsoft Office",
                            Version = "365"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Windows 10",
                            Version = "20H2"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Visual Studio Code",
                            Version = "1.50.1"
                        });
                });

            modelBuilder.Entity("Data.Entities.SoftwareLicenseEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ComputerId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("ExpirationDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("LicenseKey")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LicenseType")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("SoftwareId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ComputerId");

                    b.HasIndex("SoftwareId");

                    b.ToTable("Licences");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ComputerId = 123,
                            ExpirationDate = new DateTime(2025, 1, 1, 20, 44, 5, 994, DateTimeKind.Local).AddTicks(6222),
                            LicenseKey = "ABAB1212",
                            LicenseType = "Bussiness",
                            SoftwareId = 1
                        },
                        new
                        {
                            Id = 2,
                            ComputerId = 223,
                            ExpirationDate = new DateTime(2024, 7, 1, 20, 44, 5, 994, DateTimeKind.Local).AddTicks(6263),
                            LicenseKey = "MI45-L",
                            LicenseType = "Home",
                            SoftwareId = 2
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "8b2db4ee-e8f1-48a0-8000-9deb8c494baf",
                            ConcurrencyStamp = "8b2db4ee-e8f1-48a0-8000-9deb8c494baf",
                            Name = "admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "98c71d1e-dc1c-4a21-8926-aef703db202b",
                            ConcurrencyStamp = "98c71d1e-dc1c-4a21-8926-aef703db202b",
                            Name = "user",
                            NormalizedName = "USER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "b2025f52-a43d-4470-9684-9599cf2c0fdc",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "bc380975-ecb1-4b14-ab39-fcd3860f02e3",
                            Email = "wika@wiw.pl",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedUserName = "ADMIN",
                            PasswordHash = "AQAAAAEAACcQAAAAEDawNpYJlsvVkNLemV33+mf06pNzaaybwTElEbYRoK/i4Cl8G1x/AlsjleJuNJqsnA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "e3ec58cb-a473-4842-868d-f0c2e34db63f",
                            TwoFactorEnabled = false,
                            UserName = "wika"
                        },
                        new
                        {
                            Id = "36573f94-d8fe-495b-9e3b-466b698e3cca",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "ff97bd04-5423-4827-be9b-4b5b53fafc7c",
                            Email = "ola@wiw.pl",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedUserName = "USER",
                            PasswordHash = "AQAAAAEAACcQAAAAEHaikAsI/GEXHi+xCPGU7SIbyF0J+R+zaSDnXZpKdwUUDX+Ukt1MfD9AHQDa6cJ56Q==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "720ed0ed-6939-46c2-bb0d-1bf68d3da569",
                            TwoFactorEnabled = false,
                            UserName = "ola"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "b2025f52-a43d-4470-9684-9599cf2c0fdc",
                            RoleId = "8b2db4ee-e8f1-48a0-8000-9deb8c494baf"
                        },
                        new
                        {
                            UserId = "36573f94-d8fe-495b-9e3b-466b698e3cca",
                            RoleId = "98c71d1e-dc1c-4a21-8926-aef703db202b"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("ComputerEntitySoftwareEntity", b =>
                {
                    b.HasOne("Data.Entities.ComputerEntity", null)
                        .WithMany()
                        .HasForeignKey("ComputersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data.Entities.SoftwareEntity", null)
                        .WithMany()
                        .HasForeignKey("SoftwaresId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Data.Entities.SoftwareLicenseEntity", b =>
                {
                    b.HasOne("Data.Entities.ComputerEntity", "Computer")
                        .WithMany()
                        .HasForeignKey("ComputerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data.Entities.SoftwareEntity", "Software")
                        .WithMany()
                        .HasForeignKey("SoftwareId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Computer");

                    b.Navigation("Software");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
