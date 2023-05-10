using System;
using eLearning.Infrastructure.Data.Repository;
using eLearning.Domain.Entities;
using eLearning.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace eLearning.Infrastructure.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ElearningDbContext _dbContext;

        public UnitOfWork(ElearningDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IRepositoryAsync<T> RepositoryAsync<T>() where T : class
        {
            return new RepositoryBase<T>(_dbContext);
        }

        public Task<int> SaveChangesAsync()
        {
            return _dbContext.SaveChangesAsync();
        }
    }
}

