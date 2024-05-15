using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using UsersService.Data.Models;

namespace UsersService.Data.Contexts;


public partial class UsersDbContext : DbContext
{
    public UsersDbContext()
    {
    }

    public UsersDbContext(DbContextOptions<UsersDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<BlacklistedToken> BlacklistedTokens { get; set; }

    public virtual DbSet<Jwtsecret> Jwtsecrets { get; set; }

    public virtual DbSet<User> Users { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<BlacklistedToken>(entity =>
        {
            entity.HasKey(e => e.TokenId).HasName("PK__Blacklis__658FEE8AE2397F28");

            entity.Property(e => e.TokenId).HasColumnName("TokenID");
            entity.Property(e => e.BlacklistedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<Jwtsecret>(entity =>
        {
            entity.HasKey(e => e.SecretId).HasName("PK__JWTSecre__0F3783F16909FFF8");

            entity.ToTable("JWTSecrets");

            entity.Property(e => e.SecretId).HasColumnName("SecretID");
            entity.Property(e => e.Secret).HasMaxLength(500);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__Users__1788CCAC867074B2");

            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.Username).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
