using Microsoft.EntityFrameworkCore;
using PersonRepo.Data.Models;

namespace PersonRepo.Data.DbContexts;

public class PeopleDbContext : DbContext
{
    public PeopleDbContext(DbContextOptions<PeopleDbContext> options) : base(options)
    {
        
    }

    public DbSet<Person> People { get; set; } = null!;
    public DbSet<Student> Students { get; set; } = null!;
    public DbSet<Group> Groups { get; set; } = null!;
    public DbSet<Teacher> Teachers { get; set; } = null!;
}



