using System;
using System.Collections.Generic;

namespace PLEER;

public partial class Customer
{
    public int Id { get; set; }

    public string LastName { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string Email { get; set; } = null!;

    public virtual Cart Cart { get; set; } = null!;

    public virtual ICollection<CustomerAddress> CustomerAddresses { get; set; } = new List<CustomerAddress>();

    public virtual ICollection<Customerorder> Customerorders { get; set; } = new List<Customerorder>();

    public virtual ICollection<Review> Reviews { get; set; } = new List<Review>();
}
