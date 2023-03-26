﻿namespace ClinicSystem.Models
{
    public class DoctorSchedule
    {
        public int Id { get; set; }
        public DayOfWeek Date { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }

        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; }
    }
}
