using System.ComponentModel.DataAnnotations;

namespace b221210566_5_.Models
{
    public class EmployeeManager
    {
        [Key]
        public int id { get; set; }

        public string ManagerId { get; set; }
        public Manager Managers { get; set; }

        public string EmployeeID { get; set; }
        public Employee Employees { get; set; }
    }
}
