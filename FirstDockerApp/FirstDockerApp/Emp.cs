using System;
using System.Collections.Generic;

namespace FirstDockerApp;

public partial class Emp
{
    public int Empno { get; set; }

    public string Ename { get; set; } = null!;

    public string Job { get; set; } = null!;

    public int? Mgr { get; set; }

    public DateOnly Hiredate { get; set; }

    public int Sal { get; set; }

    public int? Comm { get; set; }

    public int Deptno { get; set; }

    public virtual Dept DeptnoNavigation { get; set; } = null!;

    public virtual ICollection<Emp> InverseMgrNavigation { get; set; } = new List<Emp>();

    public virtual Emp? MgrNavigation { get; set; }

    public virtual ICollection<Proj> Projs { get; set; } = new List<Proj>();
}
