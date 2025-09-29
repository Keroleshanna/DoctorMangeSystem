using DoctorMange.Data;
using DoctorMange.Models;
using DoctorMange.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DoctorMange.Controllers
{
    public class AppointmentController : Controller
    {
        private readonly AppDbContext _context = new();

        [HttpGet]
        public IActionResult Index(int id)
        {
            var doctor = _context.Doctors.FirstOrDefault(d => d.DoctorId == id);
            if (doctor == null) return NotFound();

            var vm = new AppointmentFormVM
            {
                DoctorId = doctor.DoctorId,
                DoctorName = doctor.Name
            };

            return View(vm); // يوديك على صفحة الحجز ومعاك داتا الدكتور
        }


        [HttpPost]
        [ValidateAntiForgeryToken] // بيتاكد من التوكن
        public IActionResult Create(AppointmentFormVM appointmentVM)
        {

            var appointment = new Appointment
            {
                Name = appointmentVM.PatientName,
                Phone = appointmentVM.Phone,
                Email = appointmentVM.Email,
                Age = appointmentVM.Age,
                BookingDate = appointmentVM.BookingDate,
                BookingTime = TimeSpan.Parse(appointmentVM.BookingTime),
                Notes = appointmentVM.Notes,
                Doctor = _context.Doctors.Find(appointmentVM.DoctorId)

            };



            _context.Appointments.Add(appointment);
            _context.SaveChanges();
            return RedirectToAction(controllerName: "Doctor", actionName: "Index");
        }


        public IActionResult List()
        {
            var allAppointments = _context.Appointments
                .Include(e => e.Doctor)
                .AsEnumerable();

            return View(allAppointments);
        }
    }
}
