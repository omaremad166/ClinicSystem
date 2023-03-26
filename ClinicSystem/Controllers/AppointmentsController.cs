using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ClinicSystem.DAL;
using ClinicSystem.Models;
using ClinicSystem.Services;
using ClinicSystem.Interfaces;

namespace ClinicSystem.Controllers
{
    public class AppointmentsController : Controller
    {
        private readonly ClinicDbContext _context;
        private readonly IAppointmentsService _appointmentsService;
        private readonly IDoctorsService _doctorsService;
        private readonly IDoctorSchedulesService _doctorSchedulesService;

        public AppointmentsController(ClinicDbContext context, IAppointmentsService appointmentsService, IDoctorsService doctorsService, IDoctorSchedulesService doctorSchedulesService)
        {
            _context = context;
            _appointmentsService = appointmentsService;
            _doctorsService = doctorsService;
            _doctorSchedulesService = doctorSchedulesService;
        }

        [Route("Appointments/Index/{doctorId?}")]
        public IActionResult Index(int doctorId, DateTime? from, DateTime? to)
        {
            var appointments = _appointmentsService.GetDoctorAppointements(doctorId, from, to);

            return View(appointments);
        }

        public IActionResult GetDoctor()
        {
            ViewBag.Doctors = _doctorsService.GetAllDoctors();

            return View("Doctor");
        }

        public IActionResult ChooseDoctor(int selectedDoctorId)
        {
            ViewBag.DateNow = DateTime.Now.ToString("yyyy-MM-dd");
            return View("Date", selectedDoctorId);
        }

        public IActionResult ChooseDate(int selectedDoctorId, DateTime date)
        {
            var timeSpanForTheDay = _doctorSchedulesService.GetDoctorScheduleByDoctorIdAndDate(selectedDoctorId, date);

            if(timeSpanForTheDay == null)
                return View("Create");

            var freeSlots = _doctorsService.GetDoctorFreeSlots(timeSpanForTheDay, selectedDoctorId, date);

            if (freeSlots.Count == 0)
                return RedirectToAction(nameof(Index));

            ViewBag.FreeSlots = freeSlots;
            ViewBag.SelectedDate = date.ToString("yyyy-MM-dd");
            ViewBag.SelectedDoctorId = selectedDoctorId;

            return View("Create");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Date,StartTime,EndTime,PatientName,BirthDate,DoctorId")] Appointment appointment)
        {
            var selectedDate = Request.Form["selectedDate"];
            var selectedDoctorId = Request.Form["selectedDoctorId"];
            var selectedSlot = Request.Form["selectedSlot"].ToString();
            TimeSpan from = TimeSpan.Parse(selectedSlot.Substring(0, 8));
            TimeSpan to = TimeSpan.Parse(selectedSlot.Substring(12));

            appointment.StartTime = from;
            appointment.EndTime = to;
            appointment.DoctorId = int.Parse(selectedDoctorId);
            appointment.Date = DateTime.Parse(selectedDate);

            _context.Add(appointment);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
