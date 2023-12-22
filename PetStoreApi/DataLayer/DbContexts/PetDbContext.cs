using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using PetsData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetsData.DbContexts;
public class PetDbContext : DbContext
{
    public DbSet<AnimalType> AnimalTypes { get; set; }
    public DbSet<Pet> Pets { get; set; }
    public DbSet<PetCategory> PetCategories { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<ProductCategory> ProductCategories { get; set; }
    public DbSet<ProductCategoryType> ProductCategoryTypes { get; set; }


    public PetDbContext(DbContextOptions<PetDbContext> options) : base(options)
    {
        
    }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        var animalTypesEntity = modelBuilder.Entity<AnimalType>();
        var petCategoriesEntity = modelBuilder.Entity<PetCategory>();
        
        var productEntity = modelBuilder.Entity<Product>();
        var productCategoryEntity = modelBuilder.Entity<ProductCategory>();
        var productCategoryTypeEntity = modelBuilder.Entity<ProductCategoryType>();


        animalTypesEntity
            .HasKey(x => x.Id);
        animalTypesEntity
            .Property(x => x.Name)
            .IsRequired();

        // -----------------------------------------

        petCategoriesEntity
            .HasKey(x => x.Id);
        petCategoriesEntity
            .Property(x => x.Name)
            .IsRequired();
        petCategoriesEntity
            .HasOne(x => x.AnimalType)
            .WithMany(x => x.PetCategories)
            .HasForeignKey(x => x.AnimalTypeID);

        // -----------------------------------------

        modelBuilder.Entity<Pet>().HasKey(x => x.Id);
        modelBuilder.Entity<Pet>(
            e =>
            {
                e.Property(x => x.Name).IsRequired();
                e.Property(x => x.Age).IsRequired();
                e.Property(x => x.Color).IsRequired();
            });

        modelBuilder.Entity<Pet>()
            .HasOne(x => x.PetCategory)
            .WithMany(x => x.Pets)
            .HasForeignKey(x => x.PetCategoryId);

        modelBuilder.Entity<Pet>()
            .HasOne(x => x.Product)
            .WithMany(x => x.Pets)
            .HasForeignKey(x => x.ProductId);


        // -------------------------------------------------------

        productEntity.HasKey(x => x.Id);
        productEntity.Property(x => x.Name).IsRequired();
        productEntity
            .HasOne(x => x.ProductCategory)
            .WithMany(x => x.Products)
            .HasForeignKey(x => x.ProductCategoryId);
        
        // -------------------------------------------------------
        productCategoryEntity.HasKey(x => x.Id);
        productCategoryEntity.Property(x => x.Name).IsRequired();
        productCategoryEntity
            .HasOne(x => x.ProductCategoryType)
            .WithMany(x => x.ProductCategories)
            .HasForeignKey(x => x.ProductCategoryTypeId);

        productCategoryEntity
            .HasOne(x => x.PetCategory)
            .WithMany(x => x.ProductCategories)
            .HasForeignKey(x => x.PetCategoryId);

        // -------------------------------------------------------

        productCategoryTypeEntity.HasKey(x => x.Id);
        productCategoryTypeEntity.Property(x => x.Name).IsRequired();
     
    }
}
