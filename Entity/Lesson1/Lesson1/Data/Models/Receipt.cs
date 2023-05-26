using System;
using System.Collections.Generic;

namespace Lesson1;

public partial class Receipt
{
    public int Id { get; set; }

    public DateTime? Date { get; set; }

    public decimal? Total { get; set; }

    public int? BoughtProductsId { get; set; }

    public virtual BoughtProduct? BoughtProducts { get; set; }
}
