using System;
using System.Linq.Expressions;

namespace eLearning.Domain.Interfaces
{
	public interface IRepositoryAsync<T> where T : class
	{
		Task<T> AddAsync(T entity);

        Task<T> UpdateAsync(T entity);

        Task<bool> DeleteAsync(T entity);

        Task<T?> GetAsync(Expression<Func<T, bool>> expression);

        Task<List<T>> GetListAsync(Expression<Func<T, bool>> expression);
    }
}

