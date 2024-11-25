using System;
using System.Collections.Generic;

namespace PLEER;

public partial class Courier
{
    public int Id { get; set; }

    public string LastName { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public virtual ICollection<Customerorder> Customerorders { get; set; } = new List<Customerorder>();
}
