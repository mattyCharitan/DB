using System;
using System.Collections.Generic;

namespace ClinicManager.Models;

public partial class Street
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int CityId { get; set; }

    public virtual ICollection<Address> Addresses { get; } = new List<Address>();

    public virtual City City { get; set; } = null!;
}
