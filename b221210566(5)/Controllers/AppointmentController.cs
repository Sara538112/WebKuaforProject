using b221210566_5_.Data;
using b221210566_5_.Models;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SQLitePCL;
using System.Linq;
using System.Text;

namespace b221210566_5_.Controllers
{
    public class AppointmentController : Controller
    {
        private readonly ILogger<AppointmentController> _logger;
        private readonly ApplicationDbContext _context;

        public AppointmentController(ILogger<AppointmentController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            ViewBag.Departments = _context.Departments.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult FetchEmployees(String departmentName)
        {
            var departments = _context.Departments.ToList();
            var employees = _context.Employees
                .Where(e => e.Dep.Name == departmentName)
                .ToList();

            ViewBag.Departments = departments;
            ViewBag.Employees = employees;
            return View("Index");
        }

        [HttpPost]
        public IActionResult FetchAvailableTimes(string employeeName, DateOnly date)
        {
            // Belirli bir çalışanın belirli bir tarihteki uygun saatlerini al
            var availableTimes = GetAvailableTimes(employeeName, date);

            // ViewBag ile uygun saatleri görünüme gönder
            ViewBag.AvailableTimes = availableTimes;
            return View("Index");
        }

        public string GetAvailableTimes(string employeeId, DateOnly date)
        {
            // Çalışanın belirli bir tarihteki randevularını al
            var appointments = _context.appointmentEmployees
                .Where(a => a.Employee.Id == employeeId && a.Appointment.Date == date)
                .Select(a => a.Appointment.Time)
                .ToList();

            // Tüm zaman aralıklarını oluştur (09:00'dan 17:00'ye kadar saat başı)
            var allTimes = Enumerable.Range(9, 9) // Saatler: 9, 10, ..., 17
                .Select(hour => TimeOnly.FromTimeSpan(new TimeSpan(hour, 0, 0))) // Saatleri TimeOnly'e dönüştür
                .ToList();

            // Uygun saatleri belirle
            var availableTimes = allTimes
                .Where(t => !appointments.Contains(t)) // Çakışmayan saatler
                .Select(t => t.ToString("HH:mm")) // String'e dönüştür
                .ToList();

            // Saatleri düz bir string olarak döndür (virgülle ayrılmış)
            return string.Join(",", availableTimes);
        }


    }

}
