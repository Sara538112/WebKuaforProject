namespace b221210566_5_.Models
{
    public class Manager:User
    {
        public ICollection<EmployeeManager> EmployeeManager { get; set; }  // A manager can have many employees

    }
}
