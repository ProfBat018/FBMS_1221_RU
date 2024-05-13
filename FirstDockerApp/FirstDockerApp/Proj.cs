using System;
using System.Collections.Generic;

namespace FirstDockerApp;

public partial class Proj
{
    public int Projid { get; set; }

    public int Empno { get; set; }

    public DateOnly Startdate { get; set; }

    public DateOnly Enddate { get; set; }

    public virtual Emp EmpnoNavigation { get; set; } = null!;
}
