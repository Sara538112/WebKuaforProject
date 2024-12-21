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
        static List<Employee> EmployeeList = new List<Employee>();
        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }
        // whereee is the otherrr model and tables
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
            EmployeeList.Add(employee);
            return View(EmployeeList);
        }
      
        
        [Authorize(Roles ="Customer")]
        public IActionResult MyAppointments() 
        {
            var userEmail = User.FindFirstValue(ClaimTypes.Email); //this is ok ?3
            // Fetch appointments specific to this customer
            var appointments = _context.appointments
                .Where(a => a.Customer.Email == userEmail)  // Assuming `Customer.UserName` is used to match the logged-in user
                .Include(a=>a.AppNo)
                .Include(a=>a.Date)
                .Include(a=>a.Time)
                .Include(a => a.Employee)  
                .Include(a => a.Employee.Dep)  
                .ToList();

            return View(appointments);
        }

        [Authorize(Roles = "Employee,Manager")]
        public IActionResult Scudule(DateOnly date)
        {
            
             var totalapp = _context.appointments
                .Where(a => a.Date == date)
                .Include (a=>a.AppNo)
                .Include(a=> a.Date)
                .Include(a=> a.Time)
                .Include(a=> a.Employee.Dep)
                .Include(a=> a.Employee.LastName)
                .Include(a=> a.Employee.LastName)
                .Include(a=> a.Period)
                .Include(a=> a.Approved)
                .ToList();
            return View(totalapp);
            
            //var employeeEmail = User.FindFirstValue(ClaimTypes.Email); // Fetch email from claims

            //if (string.IsNullOrEmpty(employeeEmail))
            //{
            //    return Unauthorized("Employee email is not found.");
            //}

            //// Fetch appointments specific to this employee
            //var schedule = _context.appointments
            //    .Where(a => a.Employee.Email == employeeEmail) // Match appointments by employee email
            //    .Include(a => a.Customer) 
            //    .Include(a => a.Employee.Dep)    
            //    .ToList();

            //if (!schedule.Any())
            //{
            //    return NotFound("No appointments found for this employee.");
            //}

        }
        [Authorize(Roles = "Manager")]
        public IActionResult ApprovedScudule(DateOnly date)
        {
            var totalapp = _context.appointments
           .Where(a => a.Date == date)
           .Include(a => a.AppNo)
           .Include(a => a.Date)
           .Include(a => a.Time)
           .Include(a => a.Employee.Dep)
           .Include(a => a.Employee.LastName)
           .Include(a => a.Employee.LastName)
           .Include(a => a.Period)
           .Include(a => a.Approved)

           .ToList();
            return View(totalapp);
        }
        [HttpPost]
        [Authorize(Roles = "Manager")]
        public IActionResult SubmitApprovals(List<Appointments> appointments)
        {
            foreach (var updatedAppointment in appointments)
            {
                // Update the appointment in the appList (or your data source)
                var existingAppointment = _context.appointments.FirstOrDefault(a => a.AppNo == updatedAppointment.AppNo);
                if (existingAppointment != null)
                {
                    existingAppointment.Approved = updatedAppointment.Approved;
                }
            }

            // Redirect back to the schedule view or a confirmation page
            return RedirectToAction("Scudule");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
