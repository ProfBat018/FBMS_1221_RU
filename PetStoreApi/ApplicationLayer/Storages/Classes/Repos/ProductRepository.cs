using ApplicationLayer.Storages.Classes.Abstractions;
using ApplicationLayer.Storages.Interfaces;
using PetsData.DbContexts;
using PetsData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.Storages.Classes.Repos;

public class ProductRepository : Repository<Product>
{
    private readonly PetDbContext _context;

    public ProductRepository(PetDbContext context) : base(context)
    {
    }
}
