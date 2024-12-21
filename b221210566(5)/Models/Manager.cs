namespace b221210566_5_.Models
{
    public class Manager:User
    {
        public ICollection<Employee> employees { get; set; }

    }
}
