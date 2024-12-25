using b221210566_5_.Data;
using b221210566_5_.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Security.Claims;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace b221210566_5_.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Servises()
        {
            return View();
        }
        public IActionResult Team(Employee employee)
        {
            var EmployeeList = _context.Employees.ToList(); // we must get employees from database not local defined list

            return View(EmployeeList);
        }


        [Authorize(Roles = "Customer")]
        public IActionResult MyAppointments()
        {
            var userEmail = User.FindFirstValue(ClaimTypes.Email); // not sure about this.

            // Fetch appointments specific to this customer

            var appointments = _context.appointments
                .Where(a => a.Customer.Email == userEmail)  // Assuming `Customer.UserName` is used to match the logged-in user
                .Include(a => a.AppNo)
                .Include(a => a.Date)
                .Include(a => a.Time)
                .Include(a => a.AppointmentEmployees)
                    .ThenInclude(ae => ae.Employee)
                .ToList();

            return View(appointments);
        }

        [Authorize(Roles = "Employee,Manager")]
        public IActionResult Scudule(DateOnly date)
        {

            var totalapp = _context.appointments
               .Where(a => a.Date == date)
               .Include(a => a.AppNo)
               .Include(a => a.Date)
               .Include(a => a.Time)
               .Include(a => a.AppointmentEmployees)
                    .ThenInclude(ae => ae.Employee)
               .Include(a => a.Period)
               .Include(a => a.Approved)
               .ToList();
            return View(totalapp);


        }
        [HttpPost]
        [Authorize(Roles = "Manager,Admin")]
        public IActionResult SubmitApprovals(List<Appointments> appointments)
        {
            foreach (var updatedAppointment in appointments)
            {
                var existingAppointment = _context.appointments.FirstOrDefault(a => a.AppNo == updatedAppointment.AppNo);
                if (existingAppointment != null)
                {
                    existingAppointment.Approved = updatedAppointment.Approved;
                }
            }

            return RedirectToAction("Scudule");
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}

