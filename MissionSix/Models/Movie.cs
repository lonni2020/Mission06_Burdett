using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace MissionSix.Models
{
    public class Movie
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string category { get; set; }
        [Required]
        public string title { get; set; }
        [Required]
        public int year { get; set; }
        [Required]
        public string director { get; set; }
        [Required]
        public string rating { get; set; }
        public bool? edited { get; set; }
        public string? lent { get; set; }
        [StringLength(25, ErrorMessage = "Notes cannot be longer than 25 characters.")]
        public string? notes { get; set; }
    }
}
