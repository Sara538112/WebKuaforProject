using System.ComponentModel.DataAnnotations;

namespace b221210566_5_.Models
{
 
    public class Appointments
    {
        [Key]
        public int AppNo {  get; set; }

        public DateOnly Date {  get; set; }

        public TimeOnly Time { get; set; }

        public float Period { get; set; }

        public float coast { get; set; } 

        public ICollection<AppointmentEmployee> AppointmentEmployees { get; set; }
        public User Customer { get; set; }
        public bool Approved { get; set; }

    }
}
