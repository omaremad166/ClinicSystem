namespace ClinicSystem.Models
{
    public class Appointment
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public string PatientName { get; set; }
        public DateTime BirthDate { get; set; }

        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; }
    }
}
