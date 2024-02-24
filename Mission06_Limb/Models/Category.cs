using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Mission06_Limb.Models;

public partial class Category
{

    [Key]
    public int CategoryId { get; set; }

    public string CategoryName { get; set; } = null!;

    public virtual ICollection<Movie> Movies { get; set; } = new List<Movie>();
}
