namespace b221210566_5_.Models
{
    public class Employee : User
    {
        public Department Dep {  get; set; }
        public string ManagerId { get; set; }
        public Manager Manager { get; set; }

        public ICollection<Appointments> Appointments { get; set; }

    }
}
