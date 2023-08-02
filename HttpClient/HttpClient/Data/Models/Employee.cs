using System;
using System.Collections.Generic;

namespace HttpClient;

public partial class Employee
{
    public int Id { get; set; }

    public decimal Salary { get; set; }

    public string Position { get; set; } = null!;

    public int PersonId { get; set; }

    public virtual Person Person { get; set; } = null!;

    public virtual Teacher? Teacher { get; set; }
}
