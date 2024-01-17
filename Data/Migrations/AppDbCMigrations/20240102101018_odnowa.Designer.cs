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
    [Migration("20240102101018_odnowa")]
    partial class odnowa
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
#pragma warning restore 612, 618
        }
    }
}
