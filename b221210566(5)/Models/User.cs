using Microsoft.AspNetCore.Identity;

namespace b221210566_5_.Models
{
    public class User : IdentityUser
    { 
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public ICollection<Appointments> Appointments { get; set; } 
    }
}
