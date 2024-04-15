using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Student
    {
        [Key]
        public int ID { get; set; }
        [Required(ErrorMessage = "Name Please")]
        public string Name { get; set; }
        public int RollNo { get; set; }
        [Required(ErrorMessage = "Class Name Please")]
        public string ClassName { get; set; }
    }

}
