using Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System;
using System.Linq;

namespace Persistence.Repositories
{
    public class Repository<T> :IRepository<T> where T : class
    {
        protected readonly DbContext _context;
        private readonly DbSet<T> _dbSet;

        public Repository(DbContext dbContext)
        {
            _context = dbContext;
            _dbSet = _context.Set<T>();
        }

        public T GetAsync(int id)
        {
            return _dbSet.Find(id);
        }

        public IEnumerable<T> GetAllAsync()
        {
            return _dbSet.ToList();
        }

        public IEnumerable<T> Where(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            return _dbSet.Where(predicate);
        }

        public T SingleOrDefaultAsync(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            return _dbSet.SingleOrDefault(predicate);
        }

        public void AddAsync(T entity)
        {
            _dbSet.Add(entity);
        }

        public void AddRangeAsync(IEnumerable<T> entities)
        {
            _dbSet.AddRange(entities);
        }

        public void Remove(T entity)
        {
            _dbSet.Remove(entity);
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
            _dbSet.RemoveRange(entities);
        }
    }
}
