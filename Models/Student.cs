using System.ComponentModel.DataAnnotations;

namespace CRUDAppASPCoreWepAPI.Models
{
    public class Student
    {
        public int id { get; set; }

        [Required]
        public string firstName { get; set; }

        [Required]
        public string lastName { get; set; }

        [Required]
        public int age { get; set; }

        [Required]
        public string email { get; set; }
    }

}

