using b221210566_5_.Data;
using b221210566_5_.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace b221210566_5_.Controllers
{
    public class ApiConsumeController : Controller
    {
        ApplicationDbContext _context;
        public ApiConsumeController(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            List<Appointments> appointments = new List<Appointments>();
            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync("https://localhost:7030/api/YazarApi/");
            var jsondata = await response.Content.ReadAsStringAsync();
            appointments = JsonConvert.DeserializeObject<List<Appointments>>(jsondata);
            return View(appointments);
        }
    }
}
