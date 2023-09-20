using Microsoft.EntityFrameworkCore;

namespace MinimalApi;

public class CarsDbContext : DbContext
{
    public DbSet<Car> Cars { get; set; }

    public CarsDbContext(DbContextOptions<CarsDbContext> options) : base(options)
    {
        
    }
}