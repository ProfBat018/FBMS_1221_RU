using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.Storages.Interfaces;

public interface IRepository<T> where T : class
{
    Task<T> GetFirstOrDefaultAsync(Expression<Func<T, bool>> filter, string? includeProperties = null, bool tracked = true);
    Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>>? filter = null, string? includeProperties = null);
    
    Task<T> FindByIdAsync(int id);
    void Add(T entity);
    void Remove(T entity);
    void RemoveRange(IEnumerable<T> entity);

    void Update(T entity);
    void SaveChanges();
}
