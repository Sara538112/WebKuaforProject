using b221210566_5_.Data;
using b221210566_5_.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace b221210566_5_.Controllers
{
    public class ManagerController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<User> _userManager;
        private readonly IUserStore<User> _userStore;
        private readonly IUserEmailStore<User> _emailStore;
        public ManagerController(ApplicationDbContext context, UserManager<User> userManager, IUserStore<User> userStore)
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
        public async Task<IActionResult> AddManagerAsync(UserRegisterDTO usr) 
        {
            Manager mng = new Manager()
            {
                Email = usr.Email,
                FirstName = usr.FirstName,
                LastName = usr.LastName,
            };



            await _userStore.SetUserNameAsync(mng, usr.Email, CancellationToken.None);
            await _emailStore.SetEmailAsync(mng, usr.Email, CancellationToken.None);
            var result = await _userManager.CreateAsync(mng, usr.Password);
            if (result.Succeeded)
            {
                var test = _context.Manager.ToList();
                await _userManager.AddToRoleAsync(mng, "Manager");
                _context.Manager.Add(mng);
                _context.SaveChanges();


            }
            return RedirectToAction("AddSuccesed");
        }
        public IActionResult AddSuccesed()
        {
            ViewBag.Message = "Manager successfully added.";
            return View();
        }
        private IUserEmailStore<User> GetEmailStore()
        {
            if (!_userManager.SupportsUserEmail)
            {
                throw new NotSupportedException("The default UI requires a user store with email support.");
            }
            return (IUserEmailStore<User>)_userStore;
        }


        [Authorize(Roles = "Manager,Admin")]
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

    

