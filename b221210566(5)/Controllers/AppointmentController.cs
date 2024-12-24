using b221210566_5_.Data;
using b221210566_5_.Models;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SQLitePCL;
using System.Text;

namespace b221210566_5_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentController : ControllerBase
    {
        private ApplicationDbContext context;

        public AppointmentController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public IActionResult GetDepartments()
        {
            var Departments = context.Departments.ToList();

            if (Departments?.Any() ?? false)// same
                return NotFound();

            return Ok(Departments);
        }

        //[HttpGet("{Id}")]
        [HttpGet]
        public IActionResult GetEmployees(int Id)
        {
            var Employees = context.Employees.Where(e => e.Dep.Id == Id);
            List<Employee> employees = Employees.ToList();

            if (employees == null || !employees.Any()) // same
                return NotFound();

            return Ok(employees);

        }

        //[HttpGet("{List<Employee>}")]
        //[HttpGet("{employeeId}")]
        [HttpGet]
        public IActionResult EmployeeAvaliblelity(int employeeId) 
        {
            // we can't add view for this method because it's in api controller.

            var employee = context.Employees.FirstOrDefault(x => x.Id == employeeId.ToString());

            if (employee == null)
                return new NotFoundResult();

            TimeOnly startTime = new TimeOnly(9,0);
            TimeOnly endTime = new TimeOnly(20,0);


            var result = string.Empty;

            var WorkTime = Enumerable.Range(0, endTime.Hour - startTime.Hour)
                .Select(i => startTime.AddHours(i))
                .ToList();

            var BusyTime = context.appointmentEmployees
                .Where(ae => ae.Employee.Id == employee.Id)
                .Select(ae => new
                {
                    startA = ae.Appointment.Time,
                    EndA = ae.Appointment.Time.AddMinutes((double)ae.Appointment.Period)
                })
                .ToList();

            var AvailbleTime = WorkTime
                .Where(Time => !BusyTime.Any(BusyTime => Time >= BusyTime.startA && Time < BusyTime.EndA))
                .Select(Time => Time.ToString("HH:MM"))
                .ToList();

            result = $"Employee : {employee.LastName} - Avalible Time : {string.Join(",", AvailbleTime)}";

            
            return Ok(result);
        }

    }
}
