using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Core.Repositories
{
    public interface IRepository<T>
    {
        // Read
        T GetAsync(int id);
        IEnumerable<T> GetAllAsync();
        IEnumerable<T> Where(Expression<Func<T, bool>> predicate);
        T SingleOrDefaultAsync(Expression<Func<T, bool>> predicate);

        // Insert
        void AddAsync(T entity);
        void AddRangeAsync(IEnumerable<T> entities);

        // Delete
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);
    }
}
