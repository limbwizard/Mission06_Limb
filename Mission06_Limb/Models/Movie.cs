using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission06_Limb.Models;

public partial class Movie
{
    public int MovieId { get; set; }

    [ForeignKey("CategoryId")]
    public int? CategoryId { get; set; }

    [Required]
    public string Title { get; set; } = null!;

    [Required]
    [Range(1888, 3000, ErrorMessage = "Year must be between 1888 and 3000")]
    public int Year { get; set; } = 1900;

    public string? Director { get; set; }

    public string? Rating { get; set; }

    [Required]
    public int Edited { get; set; }

    public string? LentTo { get; set; }

    [Required]
    public int CopiedToPlex { get; set; }

    public string? Notes { get; set; }

    public virtual Category? Category { get; set; }
}
