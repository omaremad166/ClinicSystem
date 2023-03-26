using ClinicSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace ClinicSystem.DAL
{
    public class DbInitializer
    {
        private readonly ModelBuilder modelBuilder;

        public DbInitializer(ModelBuilder modelBuilder)
        {
            this.modelBuilder = modelBuilder;
        }

        public void Seed()
        {
            modelBuilder.Entity<Doctor>().HasData(
                   new Doctor() { Id = 1, Name = "Doctor1" },
                   new Doctor() { Id = 2, Name = "Doctor2" }
            );

            modelBuilder.Entity<DoctorSchedule>().HasData(
                   new DoctorSchedule() { Id = 1, Date = DayOfWeek.Saturday, DoctorId = 1, StartTime = new TimeSpan(10, 0, 0), EndTime = new TimeSpan(12, 0, 0) },
                   new DoctorSchedule() { Id = 2, Date = DayOfWeek.Sunday, DoctorId = 1, StartTime = new TimeSpan(10, 0, 0), EndTime = new TimeSpan(12, 0, 0) },
                   new DoctorSchedule() { Id = 3, Date = DayOfWeek.Monday, DoctorId = 1, StartTime = new TimeSpan(10, 0, 0), EndTime = new TimeSpan(12, 0, 0) },
                   new DoctorSchedule() { Id = 4, Date = DayOfWeek.Tuesday, DoctorId = 1, StartTime = new TimeSpan(10, 0, 0), EndTime = new TimeSpan(12, 0, 0) },
                   new DoctorSchedule() { Id = 5, Date = DayOfWeek.Wednesday, DoctorId = 1, StartTime = new TimeSpan(10, 0, 0), EndTime = new TimeSpan(12, 0, 0) },
                   new DoctorSchedule() { Id = 6, Date = DayOfWeek.Saturday, DoctorId = 2, StartTime = new TimeSpan(15, 0, 0), EndTime = new TimeSpan(17, 0, 0) },
                   new DoctorSchedule() { Id = 7, Date = DayOfWeek.Sunday, DoctorId = 2, StartTime = new TimeSpan(15, 0, 0), EndTime = new TimeSpan(17, 0, 0) },
                   new DoctorSchedule() { Id = 8, Date = DayOfWeek.Monday, DoctorId = 2, StartTime = new TimeSpan(15, 0, 0), EndTime = new TimeSpan(17, 0, 0) },
                   new DoctorSchedule() { Id = 9, Date = DayOfWeek.Tuesday, DoctorId = 2, StartTime = new TimeSpan(15, 0, 0), EndTime = new TimeSpan(17, 0, 0) },
                   new DoctorSchedule() { Id = 10, Date = DayOfWeek.Wednesday, DoctorId = 2, StartTime = new TimeSpan(15, 0, 0), EndTime = new TimeSpan(17, 0, 0) }
            );

            modelBuilder.Entity<Appointment>().HasData(
                   new Appointment()
                   {
                       Id = 1,
                       PatientName = "Omar",
                       BirthDate = new DateTime(1998, 6, 16),
                       Date = DateTime.Now.AddDays(1),
                       DoctorId = 1,
                       StartTime = new TimeSpan(11, 0, 0),
                       EndTime = new TimeSpan(11, 30, 0)
                   },
                   new Appointment()
                   {
                       Id = 2,
                       PatientName = "Mohamed",
                       BirthDate = new DateTime(1995, 8, 1),
                       Date = DateTime.Now.AddDays(2),
                       DoctorId = 1,
                       StartTime = new TimeSpan(10, 0, 0),
                       EndTime = new TimeSpan(10, 30, 0)
                   },
                   new Appointment()
                   {
                       Id = 3,
                       PatientName = "Hosam",
                       BirthDate = new DateTime(2000, 2, 22),
                       Date = DateTime.Now.AddDays(1),
                       DoctorId = 2,
                       StartTime = new TimeSpan(16, 0, 0),
                       EndTime = new TimeSpan(16, 30, 0)
                   }
            );
        }
    }
}
