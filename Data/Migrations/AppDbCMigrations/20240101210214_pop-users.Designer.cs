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
    [Migration("20240101210214_pop-users")]
    partial class popusers
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
                            ExpirationDate = new DateTime(2025, 1, 1, 22, 2, 14, 712, DateTimeKind.Local).AddTicks(2201),
                            LicenseKey = "ABAB1212",
                            LicenseType = "Bussiness",
                            SoftwareId = 1
                        },
                        new
                        {
                            Id = 2,
                            ComputerId = 223,
                            ExpirationDate = new DateTime(2024, 7, 1, 22, 2, 14, 712, DateTimeKind.Local).AddTicks(2236),
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
                            Id = "f7d5f704-4237-4131-8f8b-3bdf06528f61",
                            ConcurrencyStamp = "f7d5f704-4237-4131-8f8b-3bdf06528f61",
                            Name = "admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "bf85911a-5257-464e-bbbb-2542c8f1f105",
                            ConcurrencyStamp = "5f0bf86c-1fce-4a10-9e6a-c380f7bd6c43",
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
                            Id = "3cfa1415-6558-4431-9b5d-3b75f8006795",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "9a313d1e-a8ca-4acd-8a82-076dcd5fa82a",
                            Email = "adam@wsei.pl",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADAM@WSEI.PL",
                            NormalizedUserName = "ADAM",
                            PasswordHash = "AQAAAAEAACcQAAAAEPO3R9SBScGwbkZDEsivJAN7/Kbsun9+KzvpuEZxoIFf2f4AJdLUBtUknYfdrpitCw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "be90fd8f-e6c8-490d-a25b-e57fd08d8be5",
                            TwoFactorEnabled = false,
                            UserName = "adam"
                        },
                        new
                        {
                            Id = "af6e98ca-8762-4848-92c0-79872338c73e",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "9ea86cc7-e17d-4454-badd-856d70ee2d3e",
                            Email = "wika@wsei.pl",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "WIKA@WSEI.PL",
                            NormalizedUserName = "WIKA",
                            PasswordHash = "AQAAAAEAACcQAAAAEAS5X2FwdGVVt9yYLb3RH353VPlWp5gYfQAxqi7WDWTr9u2zgZXAhdU1g9mjRNIRmQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "445e8043-3d8a-4abe-a2ce-d9c0a1c565ca",
                            TwoFactorEnabled = false,
                            UserName = "wika"
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
                            UserId = "3cfa1415-6558-4431-9b5d-3b75f8006795",
                            RoleId = "f7d5f704-4237-4131-8f8b-3bdf06528f61"
                        },
                        new
                        {
                            UserId = "af6e98ca-8762-4848-92c0-79872338c73e",
                            RoleId = "bf85911a-5257-464e-bbbb-2542c8f1f105"
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
