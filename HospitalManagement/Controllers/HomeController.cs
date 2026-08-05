using HospitalManagement.Models;
using Microsoft.AspNetCore.Mvc;

namespace HospitalManagement.Controllers
{
    public class HomeController : Controller
    {
        private readonly HospitalDbContext _context;

        public HomeController(HospitalDbContext context)
        {
            _context = context;
        }

        // الصفحة الرئيسية
        public IActionResult Index()
        {
            ViewBag.Departments = _context.Departments.Count();
            ViewBag.Doctors = _context.Doctors.Count();
            ViewBag.Patients = _context.Patients.Count();
            ViewBag.Appointments = _context.Appointments.Count();

            ViewBag.LatestPatients = _context.Patients
                .OrderByDescending(p => p.PatientId)
                .Take(5)
                .ToList();

            return View();
        }

        // صفحة حول النظام
        public IActionResult About()
        {
            return View();
        }
    }
}