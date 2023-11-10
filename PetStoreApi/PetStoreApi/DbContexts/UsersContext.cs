using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace PetStoreApi.DbContexts;

class UsersContext : IdentityDbContext<IdentityUser>
{
    public UsersContext(DbContextOptions<UsersContext> options) : base(options)
    {
        Database.EnsureCreated();
    }
}