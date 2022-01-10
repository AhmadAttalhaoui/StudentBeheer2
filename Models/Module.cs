using Microsoft.AspNetCore.Mvc.Rendering;
using StudentBeheer2.Areas.Identity.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentBeheer2.Models
{
    public class Module
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Titel")]
        public string Title { get; set; }

        [Required]
        [Display(Name = "Beschrijving")]
        public string Desc { get; set; }

        [Required]
        [Display(Name = "Begin Data")]
        [DataType(DataType.Date)]
        public DateTime Begin { get; set; }

        [ForeignKey("ApplicationUser")]
        [Display(Name = "Verzender")]
        public string SenderId { get; set; }
        public ApplicationUser? Sender { get; set; }

        [Required]
        [Display(Name = "Eind Data")]
        [DataType(DataType.Date)]
        public DateTime Eind { get; set; }
        /*public IList<Inschrijvingen> Inschrijvingen { get; set; }*/
        /*public SelectList ModeToSelect { get; set; }*/
        public string SelectMode { get; set; }
    }
}
