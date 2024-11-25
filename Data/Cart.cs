using System;
using System.Collections.Generic;

namespace PLEER;

public partial class Cart
{
    public int Id { get; set; }

    public int CustomerId { get; set; }

    public virtual ICollection<CartProduct> CartProducts { get; set; } = new List<CartProduct>();

    public virtual Customer Customer { get; set; } = null!;
}
