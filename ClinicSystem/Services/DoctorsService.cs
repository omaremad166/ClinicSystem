using ClinicSystem.DAL;
using ClinicSystem.Interfaces;
using ClinicSystem.Models;

namespace ClinicSystem.Services
{
    public class DoctorsService : IDoctorsService
    {
        private readonly ClinicDbContext _context;

        public DoctorsService(ClinicDbContext context)
        {
            _context = context;
        }

        public List<Doctor> GetAllDoctors()
        {
            return _context.Doctors.ToList();
        }

        public List<Slot> GetDoctorFreeSlots(DoctorSchedule timeSpanForTheDay, int selectedDoctorId, DateTime date)
        {
            List<Slot> allSlots = new();
            var noOfSlots = (timeSpanForTheDay.EndTime - timeSpanForTheDay.StartTime).Hours * 2;
            var startTime = timeSpanForTheDay.StartTime;

            for (int i = 0; i < noOfSlots; i++)
            {
                if (i != 0)
                {
                    allSlots.Add(new Slot
                    {
                        From = allSlots[i - 1].To,
                        To = allSlots[i - 1].To + new TimeSpan(0, 30, 0)
                    });
                }
                else
                {
                    allSlots.Add(new Slot
                    {
                        From = startTime,
                        To = startTime + new TimeSpan(0, 30, 0)
                    });
                }
            }

            var busyAppointements = _context.Appointments
                .Where(d => d.Date.Date == date.Date
                && d.DoctorId == selectedDoctorId)
                .ToList();

            for (int i = 0; i < noOfSlots; i++)
            {
                foreach (var busyAppointment in busyAppointements)
                {
                    if (allSlots[i].From == busyAppointment.StartTime)
                    {
                        allSlots.RemoveAt(i);
                        noOfSlots--;
                    }
                }
            }

            return allSlots;
        }
    }
}
