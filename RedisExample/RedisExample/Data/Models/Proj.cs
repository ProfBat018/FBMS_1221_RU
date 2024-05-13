using System;
using System.Collections.Generic;
using RedisExample.Models;

namespace RedisExample;

public partial class Proj : ICacheEntity
{
    public int Projid { get; set; }

    public int Empno { get; set; }

    public DateOnly Startdate { get; set; }

    public DateOnly Enddate { get; set; }

    public virtual Emp EmpnoNavigation { get; set; } = null!;
}
