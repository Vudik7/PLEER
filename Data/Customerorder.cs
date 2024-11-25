using System;
using System.Collections.Generic;

namespace PLEER;

public partial class Customerorder
{
    public int Id { get; set; }

    public int CustomerId { get; set; }

    public int AddressId { get; set; }

    public int? TransactionId { get; set; }

    public int StatusId { get; set; }

    public int? CourierId { get; set; }

    public DateTime? OrderDate { get; set; }

    public virtual Address Address { get; set; } = null!;

    public virtual Courier? Courier { get; set; }

    public virtual Customer Customer { get; set; } = null!;

    public virtual ICollection<OrderProduct> OrderProducts { get; set; } = new List<OrderProduct>();

    public virtual Status Status { get; set; } = null!;

    public virtual Transaction? Transaction { get; set; }
}
