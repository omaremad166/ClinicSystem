namespace ClinicSystem.Models
{
    public class Doctor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Appointment> Appointments { get; set; }
        public ICollection<DoctorSchedule> Schedules { get; set; }
    }
}
