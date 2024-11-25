using System;
using System.Collections.Generic;

namespace PLEER;

public partial class Address
{
    public int Id { get; set; }

    public string City { get; set; } = null!;

    public string Street { get; set; } = null!;

    public string House { get; set; } = null!;

    public string? Floor { get; set; }

    public string? Apartment { get; set; }

    public virtual ICollection<CustomerAddress> CustomerAddresses { get; set; } = new List<CustomerAddress>();

    public virtual ICollection<Customerorder> Customerorders { get; set; } = new List<Customerorder>();
}
