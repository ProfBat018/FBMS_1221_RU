using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace RedisExample;

public partial class EmployeesQxContext : DbContext
{
    public EmployeesQxContext()
    {
    }

    public EmployeesQxContext(DbContextOptions<EmployeesQxContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Datatype> Datatypes { get; set; }

    public virtual DbSet<Dept> Depts { get; set; }

    public virtual DbSet<Emp> Emps { get; set; }

    public virtual DbSet<Manager> Managers { get; set; }

    public virtual DbSet<Materialized> Materializeds { get; set; }

    public virtual DbSet<Proj> Projs { get; set; }

   
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Datatype>(entity =>
        {
            entity.HasKey(e => e.Int).HasName("PK__datatype__8D35A5095ED3F805");

            entity.ToTable("datatypes");

            entity.Property(e => e.Int)
                .HasDefaultValue(2312)
                .HasColumnName("INT_");
            entity.Property(e => e.BigInt).HasColumnName("BIG_INT");
            entity.Property(e => e.Binary)
                .HasMaxLength(50)
                .IsFixedLength()
                .HasColumnName("BINARY_");
            entity.Property(e => e.Bit)
                .HasDefaultValue(false)
                .HasColumnName("BIT_");
            entity.Property(e => e.Char)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("D")
                .IsFixedLength()
                .HasColumnName("CHAR_");
            entity.Property(e => e.Date).HasColumnName("DATE_");
            entity.Property(e => e.Datetime)
                .HasColumnType("datetime")
                .HasColumnName("DATETIME_");
            entity.Property(e => e.Datetime2)
                .HasDefaultValue(new DateTime(2012, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified))
                .HasColumnName("DATETIME2_");
            entity.Property(e => e.DatetimeOff).HasColumnName("DATETIME_OFF");
            entity.Property(e => e.Decimal)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("DECIMAL_");
            entity.Property(e => e.Float)
                .HasDefaultValue(44444.0)
                .HasColumnName("FLOAT_");
            entity.Property(e => e.Image)
                .HasColumnType("image")
                .HasColumnName("IMAGE_");
            entity.Property(e => e.Money)
                .HasDefaultValue(2233m)
                .HasColumnType("money")
                .HasColumnName("MONEY_");
            entity.Property(e => e.Nchar)
                .HasMaxLength(10)
                .HasDefaultValue("D")
                .IsFixedLength()
                .HasColumnName("NCHAR_");
            entity.Property(e => e.Ntext)
                .HasColumnType("ntext")
                .HasColumnName("NTEXT_");
            entity.Property(e => e.Numeric)
                .HasDefaultValue(234234m)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("NUMERIC_");
            entity.Property(e => e.Nvarchar)
                .HasMaxLength(50)
                .HasDefaultValue("ASDASD")
                .HasColumnName("NVARCHAR_");
            entity.Property(e => e.NvarcharMax).HasColumnName("NVARCHAR_MAX");
            entity.Property(e => e.Real).HasColumnName("REAL_");
            entity.Property(e => e.SmallDt)
                .HasColumnType("smalldatetime")
                .HasColumnName("SMALL_DT");
            entity.Property(e => e.SmallInt)
                .HasDefaultValue((short)232)
                .HasColumnName("SMALL_INT");
            entity.Property(e => e.SmallMoney)
                .HasDefaultValue(1123m)
                .HasColumnType("smallmoney")
                .HasColumnName("SMALL_MONEY");
            entity.Property(e => e.SqlVar)
                .HasColumnType("sql_variant")
                .HasColumnName("SQL_VAR");
            entity.Property(e => e.Text)
                .HasColumnType("text")
                .HasColumnName("TEXT_");
            entity.Property(e => e.Time).HasColumnName("TIME_");
            entity.Property(e => e.Timestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("TIMESTAMP_");
            entity.Property(e => e.TinyInt)
                .HasDefaultValue((byte)3)
                .HasColumnName("TINY_INT");
            entity.Property(e => e.Uid).HasColumnName("UID_");
            entity.Property(e => e.VarChar)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("zxcxcvxvcxvxv")
                .HasColumnName("VAR_CHAR");
            entity.Property(e => e.VarCharMax)
                .IsUnicode(false)
                .HasColumnName("VAR_CHAR_MAX");
            entity.Property(e => e.Varbin)
                .HasMaxLength(50)
                .HasColumnName("VARBIN");
            entity.Property(e => e.VarbinMax).HasColumnName("VARBIN_MAX");
            entity.Property(e => e.Xml)
                .HasColumnType("xml")
                .HasColumnName("XML_");
        });

        modelBuilder.Entity<Dept>(entity =>
        {
            entity.HasKey(e => e.Deptno).HasName("PK__dept__E0EB08D7333F9E48");

            entity.ToTable("dept");

            entity.Property(e => e.Deptno)
                .ValueGeneratedNever()
                .HasColumnName("DEPTNO");
            entity.Property(e => e.Dname)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DNAME");
            entity.Property(e => e.Loc)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("LOC");
        });

        modelBuilder.Entity<Emp>(entity =>
        {
            entity.HasKey(e => e.Empno).HasName("PK__emp__14CCF2EEF43B95B6");

            entity.ToTable("emp");

            entity.Property(e => e.Empno)
                .ValueGeneratedNever()
                .HasColumnName("EMPNO");
            entity.Property(e => e.Comm).HasColumnName("COMM");
            entity.Property(e => e.Deptno).HasColumnName("DEPTNO");
            entity.Property(e => e.Ename)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ENAME");
            entity.Property(e => e.Hiredate).HasColumnName("HIREDATE");
            entity.Property(e => e.Job)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("JOB");
            entity.Property(e => e.Mgr).HasColumnName("MGR");
            entity.Property(e => e.Sal).HasColumnName("SAL");

            entity.HasOne(d => d.DeptnoNavigation).WithMany(p => p.Emps)
                .HasForeignKey(d => d.Deptno)
                .HasConstraintName("fk_DEPTNO");

            entity.HasOne(d => d.MgrNavigation).WithMany(p => p.InverseMgrNavigation)
                .HasForeignKey(d => d.Mgr)
                .HasConstraintName("fk_MGR");
        });

        modelBuilder.Entity<Manager>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Managers");

            entity.Property(e => e.Employee)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Manager1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Manager");
        });

        modelBuilder.Entity<Materialized>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Materialized");

            entity.Property(e => e.Manager)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Proj>(entity =>
        {
            entity.HasKey(e => e.Projid).HasName("PK__proj__F7E0E691472152A8");

            entity.ToTable("proj");

            entity.Property(e => e.Projid)
                .ValueGeneratedNever()
                .HasColumnName("PROJID");
            entity.Property(e => e.Empno).HasColumnName("EMPNO");
            entity.Property(e => e.Enddate).HasColumnName("ENDDATE");
            entity.Property(e => e.Startdate).HasColumnName("STARTDATE");

            entity.HasOne(d => d.EmpnoNavigation).WithMany(p => p.Projs)
                .HasForeignKey(d => d.Empno)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_PROJ");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
