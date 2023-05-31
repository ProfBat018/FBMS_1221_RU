using CodeFirst.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Group = System.Text.RegularExpressions.Group;

namespace CodeFirst.Data.DbContexts;

public class AcademyDbContext : DbContext
{
    public DbSet<Person> People { get; set; }
    //public DbSet<Group> Groups { get; set; }
    public DbSet<Student> Students { get; set; }
    public DbSet<Teacher> Teachers { get; set; }

    public AcademyDbContext()
    {
        
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        ConfigurationBuilder builder = new(); // Microsoft.Extensions.Configuration.Json;
        
        builder.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
        
        IConfigurationRoot configuration = builder.Build();
        
        string connectionString = configuration.GetConnectionString("LocalConnection");
        
        optionsBuilder.UseSqlServer(connectionString);
    }
}


