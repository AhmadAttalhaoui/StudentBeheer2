using System.ComponentModel.DataAnnotations;

namespace StudentBeheer2.Models
{
    public class Inschrijvingen
    {
        [Key]
        public int InschrijvingId { get; set; }
        public int StudentId { get; set; }
        [Required]
        [Display(Name = "Student")]
        public Student Student { get; set; }

        public int ModuleId { get; set; }
        [Required]
        [Display(Name = "Module")]
        public Module module { get; set; }
    }
}
