﻿using System.Linq.Expressions;

namespace SmartServiceHub.Repository
{
    public interface IRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> predicate);

        Task AddAsync(T entity);
       void Remove(T entity);

        Task SaveChangesAsync();


    }
    
}
