using System;
using System.Collections.Generic;

namespace ClinicManager.Models;

public partial class City
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Street> Streets { get; } = new List<Street>();
}
