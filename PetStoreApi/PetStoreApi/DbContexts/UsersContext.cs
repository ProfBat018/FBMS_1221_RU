using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PetStoreApi.Models.Identity;

namespace PetStoreApi.DbContexts;

public class UsersContext : IdentityDbContext<ApplicationUser>
{
    public UsersContext(DbContextOptions<UsersContext> options) : base(options)
    {
        Database.EnsureCreated();
    }
}