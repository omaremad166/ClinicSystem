﻿// <auto-generated />
using System;
using ClinicSystem.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ClinicSystem.Migrations
{
    [DbContext(typeof(ClinicDbContext))]
    [Migration("20230326011547_Seeder-Final")]
    partial class SeederFinal
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ClinicSystem.Models.Appointment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("DoctorId")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("EndTime")
                        .HasColumnType("time");

                    b.Property<string>("PatientName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<TimeSpan>("StartTime")
                        .HasColumnType("time");

                    b.HasKey("Id");

                    b.HasIndex("DoctorId");

                    b.ToTable("Appointments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BirthDate = new DateTime(1998, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Date = new DateTime(2023, 3, 27, 3, 15, 47, 80, DateTimeKind.Local).AddTicks(1680),
                            DoctorId = 1,
                            EndTime = new TimeSpan(0, 11, 30, 0, 0),
                            PatientName = "Omar",
                            StartTime = new TimeSpan(0, 11, 0, 0, 0)
                        },
                        new
                        {
                            Id = 2,
                            BirthDate = new DateTime(1995, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Date = new DateTime(2023, 3, 28, 3, 15, 47, 80, DateTimeKind.Local).AddTicks(1698),
                            DoctorId = 1,
                            EndTime = new TimeSpan(0, 10, 30, 0, 0),
                            PatientName = "Mohamed",
                            StartTime = new TimeSpan(0, 10, 0, 0, 0)
                        },
                        new
                        {
                            Id = 3,
                            BirthDate = new DateTime(2000, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Date = new DateTime(2023, 3, 27, 3, 15, 47, 80, DateTimeKind.Local).AddTicks(1703),
                            DoctorId = 2,
                            EndTime = new TimeSpan(0, 16, 30, 0, 0),
                            PatientName = "Hosam",
                            StartTime = new TimeSpan(0, 16, 0, 0, 0)
                        });
                });

            modelBuilder.Entity("ClinicSystem.Models.Doctor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Doctors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Doctor1"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Doctor2"
                        });
                });

            modelBuilder.Entity("ClinicSystem.Models.DoctorSchedule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Date")
                        .HasColumnType("int");

                    b.Property<int>("DoctorId")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("EndTime")
                        .HasColumnType("time");

                    b.Property<TimeSpan>("StartTime")
                        .HasColumnType("time");

                    b.HasKey("Id");

                    b.HasIndex("DoctorId");

                    b.ToTable("DoctorSchedules");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Date = 6,
                            DoctorId = 1,
                            EndTime = new TimeSpan(0, 12, 0, 0, 0),
                            StartTime = new TimeSpan(0, 10, 0, 0, 0)
                        },
                        new
                        {
                            Id = 2,
                            Date = 0,
                            DoctorId = 1,
                            EndTime = new TimeSpan(0, 12, 0, 0, 0),
                            StartTime = new TimeSpan(0, 10, 0, 0, 0)
                        },
                        new
                        {
                            Id = 3,
                            Date = 1,
                            DoctorId = 1,
                            EndTime = new TimeSpan(0, 12, 0, 0, 0),
                            StartTime = new TimeSpan(0, 10, 0, 0, 0)
                        },
                        new
                        {
                            Id = 4,
                            Date = 2,
                            DoctorId = 1,
                            EndTime = new TimeSpan(0, 12, 0, 0, 0),
                            StartTime = new TimeSpan(0, 10, 0, 0, 0)
                        },
                        new
                        {
                            Id = 5,
                            Date = 3,
                            DoctorId = 1,
                            EndTime = new TimeSpan(0, 12, 0, 0, 0),
                            StartTime = new TimeSpan(0, 10, 0, 0, 0)
                        },
                        new
                        {
                            Id = 6,
                            Date = 6,
                            DoctorId = 2,
                            EndTime = new TimeSpan(0, 17, 0, 0, 0),
                            StartTime = new TimeSpan(0, 15, 0, 0, 0)
                        },
                        new
                        {
                            Id = 7,
                            Date = 0,
                            DoctorId = 2,
                            EndTime = new TimeSpan(0, 17, 0, 0, 0),
                            StartTime = new TimeSpan(0, 15, 0, 0, 0)
                        },
                        new
                        {
                            Id = 8,
                            Date = 1,
                            DoctorId = 2,
                            EndTime = new TimeSpan(0, 17, 0, 0, 0),
                            StartTime = new TimeSpan(0, 15, 0, 0, 0)
                        },
                        new
                        {
                            Id = 9,
                            Date = 2,
                            DoctorId = 2,
                            EndTime = new TimeSpan(0, 17, 0, 0, 0),
                            StartTime = new TimeSpan(0, 15, 0, 0, 0)
                        },
                        new
                        {
                            Id = 10,
                            Date = 3,
                            DoctorId = 2,
                            EndTime = new TimeSpan(0, 17, 0, 0, 0),
                            StartTime = new TimeSpan(0, 15, 0, 0, 0)
                        });
                });

            modelBuilder.Entity("ClinicSystem.Models.Appointment", b =>
                {
                    b.HasOne("ClinicSystem.Models.Doctor", "Doctor")
                        .WithMany("Appointments")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Doctor");
                });

            modelBuilder.Entity("ClinicSystem.Models.DoctorSchedule", b =>
                {
                    b.HasOne("ClinicSystem.Models.Doctor", "Doctor")
                        .WithMany("Schedules")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Doctor");
                });

            modelBuilder.Entity("ClinicSystem.Models.Doctor", b =>
                {
                    b.Navigation("Appointments");

                    b.Navigation("Schedules");
                });
#pragma warning restore 612, 618
        }
    }
}
