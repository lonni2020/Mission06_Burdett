using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;

namespace MissionSix.Models
{
    public class Movie
    {
        [Key]
        [Required]
        public int MovieId { get; set; }

        
        public int? CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public Categories Categories { get; set; }
        [Required]
        public string Title { get; set; }
        
        [Required]
        [Range(1888, int.MaxValue, ErrorMessage = "Year must be greater than or equal to 1888")]
        public int Year { get; set; }
        
        public string? Director { get; set; }
       
        public string? Rating { get; set; }
        [Required]
        public bool Edited { get; set; }

        [Required]
        public string? LentTo { get; set; }

        [Required]
        public bool CopiedToPlex { get; set; }

        [StringLength(25, ErrorMessage = "Notes cannot be longer than 25 characters.")]
        public string? Notes { get; set; }
    }
}
