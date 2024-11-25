using System;
using System.Collections.Generic;

namespace PLEER;

public partial class Status
{
    public int Id { get; set; }

    public string StatusName { get; set; } = null!;

    public virtual ICollection<Customerorder> Customerorders { get; set; } = new List<Customerorder>();
}
