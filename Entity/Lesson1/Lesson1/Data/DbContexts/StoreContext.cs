using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Lesson1;

public partial class StoreContext : DbContext
{
    public StoreContext()
    {
    }

    public StoreContext(DbContextOptions<StoreContext> options)
        : base(options)
    {
    }
    
    public DbSet<BonusCard> BonusCard { get; set; }
    public DbSet<BoughtProduct> BoughtProducts { get; set; }
    public DbSet<Customer> Customer { get; set; }
    public DbSet<Employee> Employee { get; set; }
    public DbSet<Person> Person { get; set; }
    public DbSet<Position> Position { get; set; }
    public DbSet<Product> Product { get; set; }
    public DbSet<Receipt> Receipt { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer(
            "Server=tcp:nightcall.database.windows.net,1433;Initial Catalog=Store;Persist Security Info=False;User ID=nightcall;Password=Elvin_123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

    
    // FluentApi
    public void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<BonusCard>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__BonusCar__3214EC07E22E92A3");

            entity.ToTable("BonusCard");

            entity.Property(e => e.Balance)
                .HasDefaultValueSql("((3))")
                .HasColumnType("smallmoney");

            entity.HasOne(d => d.Person).WithMany(p => p.BonusCards)
                .HasForeignKey(d => d.PersonId)
                .HasConstraintName("FK__BonusCard__Perso__59C55456");
        });

        modelBuilder.Entity<BoughtProduct>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__BoughtPr__3214EC07DF59D1BF");

            entity.HasOne(d => d.Product).WithMany(p => p.BoughtProducts)
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__BoughtPro__Produ__45BE5BA9");
        });

     

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Customer__3214EC076ED447E5");

            entity.ToTable("Customer");

            entity.HasOne(d => d.Bonus).WithMany(p => p.Customers)
                .HasForeignKey(d => d.BonusId)
                .HasConstraintName("FK__Customer__BonusI__5D95E53A");
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Employee__3214EC07172A50E3");

            entity.ToTable("Employee");

            entity.Property(e => e.Salary).HasColumnType("smallmoney");

            entity.HasOne(d => d.Person).WithMany(p => p.Employees)
                .HasForeignKey(d => d.PersonId)
                .HasConstraintName("FK__Employee__Person__55009F39");

            entity.HasOne(d => d.Position).WithMany(p => p.Employees)
                .HasForeignKey(d => d.PositionId)
                .HasConstraintName("FK__Employee__Positi__55F4C372");
        });

        modelBuilder.Entity<Person>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Person__3214EC07451486A4");

            entity.ToTable("Person");
        });

        modelBuilder.Entity<Position>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Position__3214EC079188A994");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Product__3214EC0705044331");

            entity.ToTable("Product", tb =>
            {
                tb.HasTrigger("AfterInsertTrigger");
                tb.HasTrigger("ForInsertTrigger");
            });

            entity.HasIndex(e => e.Id, "UQ__Product__3214EC06A5DABB94").IsUnique();

            entity.Property(e => e.ExpirationTime).HasColumnType("date");
            entity.Property(e => e.ProductionDate)
                .HasDefaultValueSql(
                    "(dateadd(day,round(rand()*datediff(day,dateadd(day,(-500),getdate()),getdate()),(0)),dateadd(day,(-500),getdate())))")
                .HasColumnType("date");
            entity.Property(e => e.Qrcode)
                .HasDefaultValueSql("(CONVERT([varbinary](max),newid()))")
                .HasColumnName("QRCode");
        });

        modelBuilder.Entity<Receipt>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Receipt__3214EC07C025328A");

            entity.ToTable("Receipt");

            entity.Property(e => e.Date)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("date");
            entity.Property(e => e.Total).HasColumnType("money");

            entity.HasOne(d => d.BoughtProducts).WithMany(p => p.Receipts)
                .HasForeignKey(d => d.BoughtProductsId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Receipt__BoughtP__4A8310C6");
        });

     
        modelBuilder.HasSequence<int>("SalesOrderNumber", "SalesLT");
    }
}