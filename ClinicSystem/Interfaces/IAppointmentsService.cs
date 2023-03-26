using ClinicSystem.Models;

namespace ClinicSystem.Interfaces
{
    public interface IAppointmentsService
    {
        public List<Appointment> GetDoctorAppointements(int? doctorId, DateTime? from, DateTime? to);
    }
}
