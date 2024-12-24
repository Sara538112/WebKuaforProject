namespace b221210566_5_.Models
{
    public class Employee : User
    {
        public Department Dep {  get; set; }

        public EmployeeManager EmployeeManager { get; set; }

        public ICollection<AppointmentEmployee> AppointmentEmployees { get; set; }

    }
}
