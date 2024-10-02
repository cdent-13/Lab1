using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Lab1.Models
{
    public class Employer
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        public string? PhoneNumber { get; set; }

        [Required]
        [DataType(DataType.Url)]
        public string? Website { get; set; }

        [DataType(DataType.Date)]
        public DateTime? IncorporatedDate { get; set; }

    }
}
