using System;
using System.Collections.Generic;

namespace ClinicManager.Models;

public partial class Address
{
    public int Id { get; set; }

    public int StreetId { get; set; }

    public int HouseNumber { get; set; }

    public string? Entrance { get; set; }

    public int? AppartmentNum { get; set; }

    public virtual ICollection<Patient> Patients { get; } = new List<Patient>();

    public virtual Street Street { get; set; } = null!;
}
