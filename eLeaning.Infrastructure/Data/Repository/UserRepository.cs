using System;
using eLearning.Domain.Entities;
using eLearning.Domain.Interfaces;

namespace eLeaning.Infrastructure.Data.Repository
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(ElearningDbContext dbContext) : base(dbContext)
        {
        }
    }
}

