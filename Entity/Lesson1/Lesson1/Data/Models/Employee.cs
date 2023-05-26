using System;
using System.Collections.Generic;

namespace Lesson1;

public partial class Employee
{
    public int Id { get; set; }

    public int? PersonId { get; set; }

    public int? PositionId { get; set; }

    public decimal? Salary { get; set; }

    public virtual Person? Person { get; set; }

    public virtual Position? Position { get; set; }
}
