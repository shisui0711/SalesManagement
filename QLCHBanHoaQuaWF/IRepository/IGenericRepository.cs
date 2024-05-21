using System.Linq.Expressions;

namespace QLCHWF.IRepository;

public interface IGenericRepository<T> where T : class
{
    T GetById(object key);
    Task<T?> GetByIdAsync(object key);
    IEnumerable<T> GetAll();
    Task<IEnumerable<T>> GetAllAsync();

    IEnumerable<T> GetSome(Expression<Func<T, bool>> match);
    Task<IEnumerable<T>> GetSomeAsync(Expression<Func<T, bool>> match);
    T GetOne(Expression<Func<T, bool>> match);
    Task<T> GetOneAsync(Expression<Func<T, bool>> match);
    bool Add(T entity);
    Task<bool> AddAsync(T entity);
    bool AddRange(IEnumerable<T> entities);
    Task<bool> AddRangeAsync(IEnumerable<T> entities);
    bool Update(T entity,object key);
    Task<bool> UpdateAsync(T entity,object key);
    bool UpdateRange(IEnumerable<T> entities);
    Task<bool> UpdateRangeAsync(IEnumerable<T> entities);
    bool RemoveById(Guid id);
    Task<bool> RemoveByIdAsync(Guid id);
    bool Remove(T entity);
    Task<bool> RemoveAsync(T entity);
    bool RemoveRange(IEnumerable<T> entites);
    Task<bool> RemoveRangeAsync(IEnumerable<T> entities);
}