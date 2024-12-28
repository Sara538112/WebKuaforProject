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
        private readonly UserManager<User> _userManager;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context , UserManager<User> userManager)
        {
            _logger = logger;
            _context = context;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Servises()
        {
            return View();
        }
        public IActionResult Team()
        {
            var employees = _context.Employees
                            .Include(e => e.DepEmployees) // Ensure DepEmployees is loaded
                            .ThenInclude(de => de.Department) // Ensure Department is loaded
                            .ToList();

            return View(employees);

        }

        //[Authorize(Roles = "Employee,Manager,Admin")]
        public IActionResult Scudule(DateOnly date)
        {
            date = DateOnly.FromDateTime(DateTime.Now.AddDays(1).Date);
            if (User.IsInRole("Employee") || User.IsInRole("Manager") || User.IsInRole("Admin"))
            {

                //var totalapp = _context.appointments// 
                ////.Where(a => a.Date == date)
                //.Include(a => a.AppointmentEmployees)
                //.ThenInclude(ae => ae.Employee)
                //.ToList();
                var totalapp = _context.appointmentEmployees
                    .Include(x => x.Appointment)
                    .Include(x => x.Employee)
                    .ThenInclude(emp => emp.DepEmployees)
                    .ThenInclude(depemp => depemp.Department)
                    .Where(x => x.Appointment.Date == date)
                    .ToList();
                var test = _context.appointmentEmployees.ToList();
                return View(totalapp);
            }
            return View();

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

