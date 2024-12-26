using b221210566_5_.Data;
using b221210566_5_.Models;
using b221210566_5_.Models.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
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
            return View(); 
        }

        //[Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<IActionResult> AddEmployee(UserRegisterDTO usr)
        {
            User emp = new User()
            {
                Email = usr.Email,
                FirstName = usr.FirstName,
                LastName = usr.LastName,
            };
            await _userStore.SetUserNameAsync(emp, usr.Email, CancellationToken.None);
            await _emailStore.SetEmailAsync(emp, usr.Email, CancellationToken.None);
            var result = await _userManager.CreateAsync(emp, usr.Password);
            if (result.Succeeded)
            {
                await _userManager.AddToRoleAsync(emp, "Employee");
            }
            return RedirectToAction("ListEmployees");
        }

        public IActionResult ListEmployees()
        {
            var employees = _context.Employees.ToList();  // this is a problem, or not ?
            var employees2 = _userManager.GetUsersInRoleAsync("Employee").Result;

            return View(employees);
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
