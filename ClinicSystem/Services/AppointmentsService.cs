using ClinicSystem.DAL;
using ClinicSystem.Interfaces;
using ClinicSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace ClinicSystem.Services
{
    public class AppointmentsService : IAppointmentsService
    {
        private readonly ClinicDbContext _context;

        public AppointmentsService(ClinicDbContext context)
        {
            _context = context;
        }

        public List<Appointment> GetDoctorAppointements(int? doctorId, DateTime? from, DateTime? to)
        {
            var appointmentsQueryable = _context.Appointments.AsQueryable();

            if (from != null)
            {
                appointmentsQueryable = appointmentsQueryable.Where(a => a.Date.Date >= from.Value.Date);
            }
            if (to != null)
            {
                appointmentsQueryable = appointmentsQueryable.Where(a => a.Date.Date <= to.Value.Date);
            }

            var appointments = doctorId == 0
                ? appointmentsQueryable.Include(a => a.Doctor).ToList()
                : appointmentsQueryable.Where(d => d.DoctorId == doctorId).Include(a => a.Doctor).ToList();

            return appointments;
        }
    }
}
