using System.ComponentModel.DataAnnotations;

namespace b221210566_5_.Models
{
    public class Department
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public ICollection<DepEmployee> DepEmployees { get; set; }

    }
}
