using ClinicSystem.DAL;
using ClinicSystem.Interfaces;
using ClinicSystem.Models;

namespace ClinicSystem.Services
{
    public class DoctorSchedulesService : IDoctorSchedulesService
    {
        private readonly ClinicDbContext _context;

        public DoctorSchedulesService(ClinicDbContext context)
        {
            _context = context;
        }
        public DoctorSchedule GetDoctorScheduleByDoctorIdAndDate(int selectedDoctorId, DateTime date)
        {
            DayOfWeek day = date.DayOfWeek;

            return _context.DoctorSchedules
                .Where(d => d.DoctorId == selectedDoctorId
                && d.Date == day)
                .FirstOrDefault();
        }
    }
}
