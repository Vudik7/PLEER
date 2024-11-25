using System;
using System.Collections.Generic;

namespace PLEER;

public partial class Transaction
{
    public int Id { get; set; }

    public decimal Amount { get; set; }

    public DateTime? TransactionDate { get; set; }

    public virtual Customerorder? Customerorder { get; set; }
}
