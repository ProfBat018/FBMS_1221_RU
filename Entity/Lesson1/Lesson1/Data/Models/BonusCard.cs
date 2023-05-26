using System;
using System.Collections.Generic;

namespace Lesson1;

public partial class BonusCard
{
    public int Id { get; set; }

    public int? PersonId { get; set; }

    public decimal? Balance { get; set; }

    public virtual ICollection<Customer> Customers { get; set; } = new List<Customer>();

    public virtual Person? Person { get; set; }
}
