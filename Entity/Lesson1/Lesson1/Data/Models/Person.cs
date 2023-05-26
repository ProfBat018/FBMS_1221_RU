using System;
using System.Collections.Generic;

namespace Lesson1;

public partial class Person
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Surname { get; set; } = null!;

    public int Age { get; set; }

    public virtual ICollection<BonusCard> BonusCards { get; set; } = new List<BonusCard>();

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
}
