using System.ComponentModel.DataAnnotations;

namespace b221210566_5_.Models
{
    public class DepEmployee

    {
        [Key]
        public int Id { get; set; }

        // Foreign key to Department
        public int DepartmentId { get; set; }

        // Navigation property for Department
        public Department Department { get; set; }

        // Foreign key to Employee
        public string EmployeeId { get; set; }

        // Navigation property for Employee
        public Employee Employee { get; set; }
    }
}
