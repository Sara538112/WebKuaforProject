using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace b221210566_5_.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View(); 
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public IActionResult AddEmployee()
        {
            string FirstName = HttpContext.Request.Form["FirstName"];
            string LastName = HttpContext.Request.Form["LastName"];
            string Email = HttpContext.Request.Form["Email"];
            string Password = HttpContext.Request.Form["Password"];
            TempData["Mesage"] = $"{FirstName}{LastName} Employee Eklendi";
            return RedirectToAction("Index");
        }
    }
}
