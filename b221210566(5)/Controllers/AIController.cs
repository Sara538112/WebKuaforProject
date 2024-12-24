using b221210566_5_.Data;
using Microsoft.AspNetCore.Mvc;

namespace b221210566_5_.Controllers
{
    public class AIController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AIController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

    }
}
