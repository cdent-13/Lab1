using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Lab1.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [Display(Name="First Name")]
        public string? FirstName { get; set; }

        [Required]
        [Display(Name ="Last Name")]
        public string? LastName { get; set; }

        [Required]
        [Display(Name="Birth Date")]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
    }
}
