using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace StudentBeheer2.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Voornaam")]
        public string Voornaam { get; set; }

        [Required]
        [Display(Name = "Achternaam")]
        public string Achternaam { get; set; }

        [Required]
        [Display(Name = "Geboren op")]
        [DataType(DataType.Date)]
        public DateTime Geboortedatum { get; set; }



        public Gender Gender { get; set; }
        /*public IList<Inschrijvingen> Inschrijvingen { get; set; }*/
    }
    public class StudentIndexViewModel
    {
        public int SelectedItem { get; set; }
        public string SearchField { get; set; }
        public List<Student> Students { get; set; }
        public SelectList GenderToSelect { get; set; }
    }
}
