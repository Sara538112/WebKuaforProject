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
        private static Employee _selectedEmployee;
        private static Department _selectedDepartment;

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
        public IActionResult fetchDepartments()
        {
            var departments = _context.Departments.ToList();
            ViewBag.Departments = departments;
            return View("Index");

        }

        [HttpPost]
        public IActionResult FetchEmployees(string departmentName)
        {
            _selectedDepartment = _context.Departments.AsNoTracking().FirstOrDefault(x => x.Name == departmentName);
            var employees = _context.DepEmployees
                .Where(e => e.Department.Name == departmentName)
                .Include(e => e.Employee)
                 .Select(e => e.Employee)
                .ToList();
            ViewBag.Employees = employees;

            return View("Index");
        }

        [HttpPost]
        public IActionResult FetchAvailableTimes(string employeeName, DateOnly date)
        {
            var availableTimes = GetAvailableTimes(employeeName, date);

            ViewBag.AvailableTimes = availableTimes;
            return View("Index");
        }

        public List<string> GetAvailableTimes(string employeeId, DateOnly date)
        {
            _selectedEmployee = _context.Employees.AsNoTracking().FirstOrDefault(x => x.Id == employeeId);

            var appointments = _context.appointmentEmployees.Where(x=>x.EmployeeId == employeeId)
                .Include(x=>x.Appointment)
                .Select(a => a.Appointment.Time)
                .ToList();

            //Tüm zaman aralıklarını oluştur(09:00'dan 17:00'ye kadar saat başı)
            var allTimes = Enumerable.Range(9, 9) // Saatler: 9, 10, ..., 17
                .Select(hour => TimeOnly.FromTimeSpan(new TimeSpan(hour, 0, 0))) // Saatleri TimeOnly'e dönüştür
                .ToList();


            // Uygun saatleri belirle
            var availableTimes = allTimes
                .Where(t => !appointments.Contains(t)) // Çakışmayan saatler
                .Select(t => t.ToString("HH:mm")) // String'e dönüştür
                .ToList();

            // Saatleri düz bir string olarak döndür (virgülle ayrılmış)
            return availableTimes;
        }
        [HttpPost]
        public IActionResult create(TimeOnly time)
        {
            var employee = _selectedEmployee;
            var dep = _selectedDepartment;
            var AppEmployee = _context.Employees.AsNoTracking().FirstOrDefault(e => e.Id == employee.Id);


            AppointmentEmployee appointmentEmployee = new AppointmentEmployee();
            DepEmployee depEmployee1 = new DepEmployee();


            Appointments appointments = new Appointments()
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(1).Date),
                Time = time,
            };
            DepEmployee depEmployee = new DepEmployee()
            {
                Department = dep,
            };


            _context.appointments.Add(appointments);
            _context.SaveChanges();
            appointmentEmployee.AppointmentId = appointments.AppNo;
            appointmentEmployee.EmployeeId = employee.Id;
            _context.appointmentEmployees.Add(appointmentEmployee);
            _context.SaveChanges();
            return RedirectToAction("AddSuccesed");
        }
        public IActionResult AddSuccesed()
        {
            ViewBag.Message = " Appointment successfully added.";
            return View();
        }


    }

}
