using DoctorMange.Data;
using DoctorMange.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DoctorMange.Controllers
{
    public class DoctorController : Controller
    {
        AppDbContext _context = new();
        public IActionResult Index(FilterVM filterVM, int page = 1)
        {
            var doctorsQuery = _context.Doctors.Include(d => d.Departments).AsQueryable();

            if (!string.IsNullOrWhiteSpace(filterVM.DoctorName))
            {
                doctorsQuery = doctorsQuery.Where(d => d.Name.Contains(filterVM.DoctorName.Trim()));
                ViewBag.SaveDoctorName = filterVM.DoctorName;
            }

            if (filterVM.Specialis >= 1)
            {
                doctorsQuery = doctorsQuery.Where(d => d.Specialisation == filterVM.Specialis);
                ViewBag.SaveSpecialis = filterVM.Specialis;
            }

            if (filterVM.IsActive)
            {
                doctorsQuery = doctorsQuery.Where(d => d.Departments.IsActive == filterVM.IsActive);
                ViewBag.SaveActive = filterVM.IsActive;
            }

            var countPages = Math.Ceiling(doctorsQuery.Count() / 6.0);
            doctorsQuery = doctorsQuery.Skip((page - 1) * 6).Take(6);
            ViewBag.CountPage = countPages;
            ViewBag.CurrentPage = page;

            ViewData["AllDoctors"] = doctorsQuery.ToList();

            ViewData["AllDepartments"] = _context.Departments.ToList();

            return View();
        }
    }
}
