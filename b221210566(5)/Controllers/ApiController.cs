using b221210566_5_.Data;
using b221210566_5_.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Newtonsoft.Json;

namespace b221210566_5_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public ApiController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet("{no}")]
        public ActionResult<Appointments> get(int no)
        {
            var App = _context.appointments.FirstOrDefault(x => x.AppNo ==no );
            if (App is null)
            {
                return NoContent();
            }
            return App;

        }
        [HttpDelete("{no}")]
        public ActionResult Delete(int no)
        {
            var App =_context.appointments.FirstOrDefault(x => x.AppNo == no);
            if (App is null)
            {
                return NotFound();
            }
          
            _context.appointments.Remove(App);
            _context.SaveChanges();
            return Ok();
        }
    }
}
