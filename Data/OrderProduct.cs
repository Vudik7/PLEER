﻿using System;
using System.Collections.Generic;

namespace PLEER;

public partial class OrderProduct
{
    public int Id { get; set; }

    public int OrderId { get; set; }

    public int ProductId { get; set; }

    public virtual Customerorder Order { get; set; } = null!;

    public virtual Product Product { get; set; } = null!;
}
