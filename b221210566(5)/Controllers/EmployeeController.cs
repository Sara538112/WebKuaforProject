using b221210566_5_.Data;
using b221210566_5_.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace b221210566_5_.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<User> _userManager;
        private readonly IUserStore<User> _userStore;
        private readonly IUserEmailStore<User> _emailStore;

        public EmployeeController(ApplicationDbContext context, UserManager<User> userManager, IUserStore<User> userStore)
        {
            _context = context;
            _userManager = userManager;
            _userStore = userStore;
            _emailStore = GetEmailStore();
        }

        public IActionResult Index()
        {
            var selectListItem = new List<SelectListItem>();
            var deps = _context.Departments.ToList();
            foreach(var dep in deps)
            {
                selectListItem.Add(new SelectListItem() { Text = dep.Name, Value = dep.Name});
            }
            ViewData["DepeartmentSelectList"] = selectListItem;
            return View(); 
        }

        //[Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<IActionResult> AddEmployee(UserRegisterDTO usr)
        {
            var dep = _context.Departments.FirstOrDefault(x => x.Name == usr.Department);
            Employee emp = new Employee()
            {
                Email = usr.Email,
                FirstName = usr.FirstName,
                LastName = usr.LastName,
            };

            // Create a new DepEmployee to link the Employee with the Department
            DepEmployee depEmployee = new DepEmployee()
            {
                Department = dep, // Assign the found department
                Employee = emp    // Link the employee
            };

            emp.DepEmployees = depEmployee;


            await _userStore.SetUserNameAsync(emp, usr.Email, CancellationToken.None);
            await _emailStore.SetEmailAsync(emp, usr.Email, CancellationToken.None);
            var result = await _userManager.CreateAsync(emp, usr.Password);
            if (result.Succeeded)
            {
                var test = _context.Employees.ToList();
                await _userManager.AddToRoleAsync(emp, "Employee");
                _context.Employees.Add(emp);
                _context.SaveChanges();

                _context.DepEmployees.Add(depEmployee);
                _context.SaveChanges();
            }
            return RedirectToAction("Home","Team");
        }

        
        private IUserEmailStore<User> GetEmailStore()
        {
            if (!_userManager.SupportsUserEmail)
            {
                throw new NotSupportedException("The default UI requires a user store with email support.");
            }
            return (IUserEmailStore<User>)_userStore;
        }
    }
}
