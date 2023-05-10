using System;
using eLearning.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using eLearning.Domain.Interfaces;

namespace eLeaning.Infrastructure.Data.Repository
{
    public class RepositoryBase<T> : IRepositoryAsync<T> where T : class
    {
        private readonly DbSet<T> _dbSet;

        public RepositoryBase(ElearningDbContext dbContext)
        {
            _dbSet = dbContext.Set<T>();
        }

        public async Task<T> AddAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
            return entity;
        }

        public Task<bool> DeleteAsync(T entity)
        {
            _dbSet.Remove(entity);
            return Task.FromResult(true);
        }

        public Task<T> UpdateAsync(T entity)
        {
            _dbSet.Update(entity);
            return Task.FromResult(entity);
        }

        public Task<T?> GetAsync(Expression<Func<T, bool>> expression)
        {
            return _dbSet.FirstOrDefaultAsync(expression);
        }

        public Task<List<T>> GetListAsync(Expression<Func<T, bool>> expression)
        {
            return _dbSet.Where(expression).ToListAsync();
        }
    }
}

