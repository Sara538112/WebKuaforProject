using b221210566_5_.Data;
using b221210566_5_.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace b221210566_5_.Controllers
{
    public class ManagerController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ManagerController( ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public IActionResult AddManager() 
        {
            string FirstName = HttpContext.Request.Form["FirstName"];
            string LastName = HttpContext.Request.Form["LastName"];
            string Email = HttpContext.Request.Form["Email"];
            string Password = HttpContext.Request.Form["Password"];

            TempData["Mesage"] = $"{FirstName}{LastName} Manager Eklendi";
            return RedirectToAction("Index");
        }

        [Authorize(Roles = "Manager")]
        public IActionResult ApprovedScudule(DateOnly date)
        {

            var totalapp = _context.appointments
           .Where(a => a.Date == date)
           .Include(a => a.AppNo)
           .Include(a => a.Date)
           .Include(a => a.Time)
           .Include(a => a.AppointmentEmployees)
            .ThenInclude(a => a.Employee)
           .Include(a => a.Period)
           .Include(a => a.Approved)

           .ToList();
            return View(totalapp);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

    

