using System;
using System.Collections.Generic;

namespace MinimalApi.Data.Models;

public partial class Student
{
    public int Id { get; set; }

    public int PersonId { get; set; }

    public int GroupId { get; set; }

    public double Gpa { get; set; }

    public virtual Group Group { get; set; } = null!;

    public virtual Person Person { get; set; } = null!;
}
