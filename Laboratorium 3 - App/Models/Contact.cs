using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Laboratorium_3___App.Models
{
    public enum Priority
    {
        [Display(Name = "Niski")] Low = 1,
        [Display(Name = "Normalny")] Normal = 2,
        [Display(Name = "Wysoki")] High = 3,
        [Display(Name = "Pilny")] Urgent = 4
    }
    public class Contact
    {
        [HiddenInput]
        public int Id { get; set; }
        [Required(ErrorMessage = "Musisz podać imię")]
        [StringLength(maximumLength: 50, ErrorMessage = "Zbyt długie imię, podaj mniej niż 50 znaków")]
        [Display(Name = "Imię")]
        public string Name { get; set; }
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Phone]
        [Display(Name = "Numer telefonu")]
        public string Phone { get; set; }
        [Display(Name = "Data urodzenia")]
        [DataType(DataType.Date)]
        public DateTime? Birth { get; set; }

        [Display(Name = "Priorytet")]
        public Priority Priority { get; set; }
        [HiddenInput]
        public DateTime Created { get; set; }

    }
}

