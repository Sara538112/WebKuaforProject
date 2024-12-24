using System.ComponentModel.DataAnnotations;


namespace b221210566_5_.Models
{
    public class AppointmentEmployee
    {
        [Key]
        public int Id { get; set; } // Primary Key

        public int AppointmentId { get; set; } // Foreign Key
        public Appointments Appointment { get; set; } 

        public string EmployeeId { get; set; } 
        public Employee Employee { get; set; }

        public String AvaliableTime {  get; set; }  

    }
}
