using ClinicSystem.Models;

namespace ClinicSystem.Interfaces
{
    public interface IDoctorSchedulesService
    {
        public DoctorSchedule GetDoctorScheduleByDoctorIdAndDate(int selectedDoctorId, DateTime date);
    }
}
