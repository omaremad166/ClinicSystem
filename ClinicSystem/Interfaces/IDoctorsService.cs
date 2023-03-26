using ClinicSystem.Models;

namespace ClinicSystem.Interfaces
{
    public interface IDoctorsService
    {
        public List<Doctor> GetAllDoctors();
        public List<Slot> GetDoctorFreeSlots(DoctorSchedule timeSpanForTheDay, int selectedDoctorId, DateTime date);
    }
}
