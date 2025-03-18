namespace StudentApp.Models
{
    using System.ComponentModel.DataAnnotations;

    namespace StudentApp.Models
    {
        public class Student
        {
            [Key]
            public int StudentId { get; set; }

            [Required]
            public string Name { get; set; }
        }
    }

}
