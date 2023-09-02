using System.ComponentModel.DataAnnotations;
namespace EFCodeFirstA.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }

        public string? Address { get; set; }

        [Required]
        public string? PhoneNumber { get; set; }
    }
}
