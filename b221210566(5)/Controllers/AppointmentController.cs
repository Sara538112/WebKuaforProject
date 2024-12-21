using b221210566_5_.Data;
using b221210566_5_.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace b221210566_5_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public AppointmentController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet("Departments")] 
        public async Task<ActionResult<IEnumerable<Department>>> GetDepartments()
        {
            return await _context.Set<Department>().ToListAsync();//perfect
            // return await _context.Departments.ToListAsunc();
        }


        [HttpGet("EmployeesByDepartment/{departmentId}")]
        public async Task<ActionResult<IEnumerable<Employee>>> GetEmployeesByDepartment(int departmentId)//perfect
        {
            var employees = await _context.Employees
                .Include(e => e.Dep) // Department ilişkisini yükler
                .Where(e => e.Dep.Id == departmentId)
                .ToListAsync();

            if (!employees.Any())
            {
                return NotFound("No employees found in this department.");
            }

            return employees;
        }


        [HttpGet("AvailableTimes/{employeeId}")]
        public async Task<ActionResult<IEnumerable<string>>> GetAvailableTimes(int employeeId)// perfect
        {
            var appointments = await _context.appointments
                .Where(a => a.Employee.Id == employeeId.ToString() )
                .Select(a => a.Time)
                .ToListAsync();

            // Örnek bir zaman aralığı (8:00 - 21:00 arası her saat başı)
            var allTimes = Enumerable.Range(8, 13).Select(hour => $"{hour}:00").ToList();

            // Uygun olmayan saatleri çıkar
            var availableTimes = allTimes.Where(t => !appointments.Contains(TimeOnly.Parse(t))).ToList();

            return availableTimes;
        }


        [HttpPost("Create")]
        public async Task<ActionResult<Appointments>> CreateAppointment(Appointments appointment)//perfect
        {
            if (appointment == null)
            {
                return BadRequest("Appointment data is null.");
            }

            _context.appointments.Add(appointment);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(CreateAppointment), new { id = appointment.AppNo }, appointment);
        }


    }
}
