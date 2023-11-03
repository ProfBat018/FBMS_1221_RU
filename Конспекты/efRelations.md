# Отношения между сущностями в Entity Framework

Если мы работаем через Fluent Api, то в таком случае нужно самому прописать отношения.

Всего есть 3 типа отношений:
- One-to-One
- One-to-Many
- Many-to-Many

Пример  One-to-One:
```csharp
public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int? ProfileId { get; set; }
    public Profile Profile { get; set; }
}

public class Profile
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int? UserId { get; set; }
    public User User { get; set; }
}

protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    modelBuilder.Entity<User>()
        .HasOne(u => u.Profile)
        .WithOne(p => p.User)
        .HasForeignKey<Profile>(p => p.UserId);
}
```

Пример  One-to-Many:
```csharp

public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Phone> Phones { get; set; }
}

public class Phone
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int UserId { get; set; }
    public User User { get; set; }
}

protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    modelBuilder.Entity<User>()
        .HasMany(u => u.Phones)
        .WithOne(p => p.User)
        .HasForeignKey(p => p.UserId);
}
```

Пример  Many-to-Many:
```csharp

public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<UserRole> UserRoles { get; set; }
}

public class Role
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<UserRole> UserRoles { get; set; }
}

public class UserRole
{
    public int UserId { get; set; }
    public User User { get; set; }
    public int RoleId { get; set; }
    public Role Role { get; set; }
}

protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    modelBuilder.Entity<UserRole>()
        .HasKey(ur => new { ur.UserId, ur.RoleId });

    modelBuilder.Entity<UserRole>()
        .HasOne(ur => ur.User)
        .WithMany(u => u.UserRoles)
        .HasForeignKey(ur => ur.UserId);

    modelBuilder.Entity<UserRole>()
        .HasOne(ur => ur.Role)
        .WithMany(r => r.UserRoles)
        .HasForeignKey(ur => ur.RoleId);
}
```

