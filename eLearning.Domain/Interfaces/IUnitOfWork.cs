using System;
using eLearning.Domain.Entities;

namespace eLearning.Domain.Interfaces
{
	public interface IUnitOfWork
	{
		Task<int> SaveChangesAsync();

        IRepositoryAsync<T> RepositoryAsync<T>() where T : class;
    }
}

