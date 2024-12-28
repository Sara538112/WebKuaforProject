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
        //public async Task<IActionResult> index()
        //{
        //    List<Appointments> Appointments = new List<Appointments>();
        //    var httpClient = new HttpClient();
        //    var respone = await httpClient.GetAsync("http:/localhost:7177/api");
        //    var jsondata=await respone.Content.ReadAsStringAsync();
        //    var appointments = JsonConvert.DeserializeObject<List<Appointments>>(jsondata);
        //    return View(appointments);
        //}

        // DELETE: api/AppointmentApi/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAppointment(int id)
        {
            // Find the appointment by its ID
            var appointment = await _context.appointments.FindAsync(id);

            // If the appointment doesn't exist, return a 404 Not Found
            if (appointment == null)
            {
                return NotFound();
            }

            // Remove the appointment from the database
            _context.appointments.Remove(appointment);
            await _context.SaveChangesAsync();

            // Return a success message
            return NoContent();
        }
    }
}
