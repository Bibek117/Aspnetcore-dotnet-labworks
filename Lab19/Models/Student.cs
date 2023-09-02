using System.ComponentModel.DataAnnotations;

namespace Lab19.Models
{
    public class Student
    {
        [Required]
        public int StdID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Faculty { get; set; }
    }
}