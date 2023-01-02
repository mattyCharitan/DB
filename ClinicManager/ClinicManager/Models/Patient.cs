using System;
using System.Collections.Generic;

namespace ClinicManager.Models;

public partial class Patient
{
    public int Code { get; set; }

    public string Id { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public DateTime BirthDate { get; set; }

    public string MobileNumber { get; set; } = null!;

    public int? AddressId { get; set; }

    public virtual Address? Address { get; set; }
}
