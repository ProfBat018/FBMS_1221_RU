using Microsoft.EntityFrameworkCore;
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
    public DbSet<ProductCategory> ProductCategories { get; set; }
    public DbSet<ProductType> ProductTypes { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        var animalTypesEntity = modelBuilder.Entity<AnimalType>();
        var petCategoriesEntity = modelBuilder.Entity<PetCategory>();
        var petsEntity = modelBuilder.Entity<Pet>();
        var productCategoriesEntity = modelBuilder.Entity<ProductCategory>();
        var productTypesEntity = modelBuilder.Entity<ProductType>();


        animalTypesEntity
            .HasKey(x => x.Id);
        animalTypesEntity
            .Property(x => x.Id)
            .ValueGeneratedOnAdd();
        animalTypesEntity
            .Property(x => x.Name)
            .HasMaxLength(30)
            .IsRequired();

        // -----------------------------------------

        productTypesEntity
            .HasKey(x => x.Id);
        productTypesEntity
            .Property(x => x.Id)
            .ValueGeneratedOnAdd();
        productTypesEntity
            .Property(x => x.Name)
            .HasMaxLength(30)
            .IsRequired();
        
        // -----------------------------------------

        productCategoriesEntity
            .HasKey(x => x.Id);
        productCategoriesEntity
            .Property(x => x.Id)
            .ValueGeneratedOnAdd();
        productCategoriesEntity
            .Property(x => x.Name)
            .HasMaxLength(30)
            .IsRequired();

        // -----------------------------------------

        petCategoriesEntity
            .HasKey(x => x.Id);

        petCategoriesEntity
            .Property(x => x.Id)
            .ValueGeneratedOnAdd();

        petCategoriesEntity
            .Property(x => x.Name)
            .HasMaxLength(30)
            .IsRequired();
    }
}
