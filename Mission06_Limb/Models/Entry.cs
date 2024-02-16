using System.ComponentModel.DataAnnotations;

namespace Mission06_Limb.Models
{
    public class Entry
    {
        [Key]
        [Required]
        public int MovieId { get; set; }
        
        [Required]
        public string Title { get; set; }
        
        [Required]
        public string Director { get; set; }

        [Required]
        [Range(1900, 9999)]
        public int ReleaseYear { get; set; }

        [Required]
        public string Genre { get; set; }

        [Required]
        public string Rating { get; set; }

        public bool Edited { get; set; } = false; // Default to false if not provided

        public string LentTo { get; set; }

        [MaxLength(25)]
        public string Notes { get; set; }
    }
}
