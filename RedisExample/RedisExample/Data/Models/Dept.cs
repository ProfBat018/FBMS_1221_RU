using System;
using System.Collections.Generic;
using RedisExample.Models;

namespace RedisExample;

public partial class Dept : ICacheEntity
{
    public int Deptno { get; set; }

    public string Dname { get; set; } = null!;

    public string Loc { get; set; } = null!;

    public virtual ICollection<Emp> Emps { get; set; } = new List<Emp>();
}
