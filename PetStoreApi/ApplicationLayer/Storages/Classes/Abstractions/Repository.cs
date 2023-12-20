using ApplicationLayer.Storages.Interfaces;
using Microsoft.EntityFrameworkCore;
using PetsData.DbContexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.Storages.Classes.Abstractions;

public class Repository<T> : IRepository<T> where T : class
{
    private readonly DbSet<T> _dbSet;
    internal PetDbContext _context;

    public Repository(PetDbContext context)
    {
        _context = context;

        _context.Database.EnsureCreated();

        _dbSet = _context.Set<T>();
    }

    public void Add(T entity)
    {
        _dbSet.Add(entity);
    }

    public async Task<T> FindByIdAsync(int id)
    {
        return await _dbSet.FindAsync(id);
    }

    // repo.GetAll(x => x.Id = 5, "ProductCategory, Pets")
    public async Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>>? filter = null, string? includeProperties = null)
    {
        IQueryable<T> query = _dbSet;

        if (filter != null)
            query = query.Where(filter);

        if (includeProperties != null)
        {
            foreach (var includeProp in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProp);
            }
        }
        return await query.ToListAsync();
    }

    public async Task<T> GetFirstOrDefaultAsync(Expression<Func<T, bool>> filter, string? includeProperties = null, bool tracked = true)
    {
        IQueryable<T> query;

        if (tracked)
            query = _dbSet;
        else
            query = _dbSet.AsNoTracking();


        if (filter != null)
            query = query.Where(filter);


        if (includeProperties != null)
        {
            foreach (var includeProp in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProp);
            }
        }
        return await query.FirstOrDefaultAsync();
    }

    public void Remove(T entity)
    {
        _dbSet.Remove(entity);
    }

    public void RemoveRange(IEnumerable<T> entity)
    {
        _dbSet.RemoveRange(entity);
    }

    public void SaveChanges()
    {
        _context.SaveChanges();
    }

    public void Update(T entity)
    {
        _context.Update(entity);
    }
}
