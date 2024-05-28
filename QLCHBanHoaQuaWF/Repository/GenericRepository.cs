using Microsoft.EntityFrameworkCore;
using QLCHWF.IRepository;
using System.Linq.Expressions;
using QLCHWF.Models;

namespace QLCHWF.Repository;

public class GenericRepository<T> : IGenericRepository<T> where T : class
{
    private readonly MyAppContext _context;
    public GenericRepository(MyAppContext context)
    {
        _context = context;
    }
    public T? GetById(object key)
    {
        return _context.Set<T>().Find(key)!;
    }

    #nullable enable
    public async Task<T?> GetByIdAsync(object key)
    {
        return await _context.Set<T>().FindAsync(key);
    }

    public IEnumerable<T> GetAll()
    {
        return _context.Set<T>().ToList();
    }

    public async Task<IEnumerable<T>> GetAllAsync()
    {
        return await _context.Set<T>().ToListAsync();
    }

    public IEnumerable<T> GetSome(Expression<Func<T, bool>> match)
    {
        return _context.Set<T>().Where(match);
    }

    public async Task<IEnumerable<T>> GetSomeAsync(Expression<Func<T, bool>> match)
    {
        return await _context.Set<T>().Where(match).AsNoTracking().ToArrayAsync();
    }

    public T? GetOne(Expression<Func<T, bool>> match)
    {
        return _context.Set<T>().Where(match).FirstOrDefault();
    }

    public async Task<T?> GetOneAsync(Expression<Func<T, bool>> match)
    {
        return await _context.Set<T>().Where(match).FirstOrDefaultAsync();
    }

    public T? GetOneInluce<TProperty>(Expression<Func<T, TProperty>> selector, Expression<Func<T, bool>> match)
    {
        return _context.Set<T>().Include(selector).FirstOrDefault(match);
    }

    public IEnumerable<T> GetSomeInclude<TProperty>(Expression<Func<T, TProperty>> selector, Expression<Func<T, bool>> match)
    {
        return _context.Set<T>().Include(selector).Where(match);
    }

    public bool Add(T entity)
    {
        using var transaction = _context.Database.BeginTransaction();
        try
        {
            _context.Entry(entity).State = EntityState.Added;
            _context.SaveChanges();
            transaction.Commit();
            return true;
        }
        catch (Exception)
        {
            transaction.Rollback();
            return false;
        }
    }

    public async Task<bool> AddAsync(T entity)
    {
        await using var transaction = await _context.Database.BeginTransactionAsync();
        try
        {
            await _context.Set<T>().AddAsync(entity);
            await _context.SaveChangesAsync();
            await transaction.CommitAsync();
            return true;
        }
        catch
        {
            await transaction.RollbackAsync();
            return false;
        }
    }

    public bool AddRange(IEnumerable<T> entities)
    {
        using var transaction = _context.Database.BeginTransaction();
        try
        {
            _context.Set<T>().AddRange(entities);
            _context.SaveChanges();
            transaction.Commit();
            return true;
        }
        catch (Exception)
        {
            transaction.Rollback();
            return false;
        }
    }

    public async Task<bool> AddRangeAsync(IEnumerable<T> entities)
    {
        await using var transaction = await _context.Database.BeginTransactionAsync();
        try
        {
            await _context.Set<T>().AddRangeAsync(entities);
            await _context.SaveChangesAsync();
            await transaction.CommitAsync();
            return false;
        }
        catch (Exception)
        {
            await transaction.RollbackAsync();
            return false;
        }
    }


    public bool Update(T entity,object? key)
    {
        using var transaction = _context.Database.BeginTransaction();
        try
        {
            T? entityExist = _context.Set<T>().Find(key);
            if (entityExist == null)
            {
                return false;
            }

            _context.Entry(entityExist).State = EntityState.Detached;
            _context.Entry(entity).State = EntityState.Modified;
            _context.Set<T>().Update(entity);
            _context.SaveChanges();
            transaction.Commit();
            return true;

        }
        catch (Exception)
        {
            transaction.Rollback();
            return false;
        }
    }

    public async Task<bool> UpdateAsync(T entity,object? key)
    {
        await using var transaction = await _context.Database.BeginTransactionAsync();
        try
        {
            T? entityExist = await _context.Set<T>().FindAsync(key);
            if (entityExist == null)
            {
                return false;
            }

            _context.Entry(entityExist).State = EntityState.Detached;
            _context.Entry(entityExist).State = EntityState.Modified;
            _context.Set<T>().Update(entity);
            await _context.SaveChangesAsync();
            await transaction.CommitAsync();
            return true;

        }
        catch (Exception)
        {
            await transaction.RollbackAsync();
            return false;
        }
    }

    public bool UpdateRange(IEnumerable<T> entities)
    {
        using var transaction = _context.Database.BeginTransaction();
        try
        {
            _context.Set<T>().UpdateRange(entities);
            _context.SaveChanges();
            transaction.Commit();
            return true;

        }
        catch (Exception)
        {
            transaction.Rollback();
            return false;
        }
    }

    public async Task<bool> UpdateRangeAsync(IEnumerable<T> entities)
    {
        await using var transaction = await _context.Database.BeginTransactionAsync();
        try
        {
            _context.Set<T>().UpdateRange(entities);
            await _context.SaveChangesAsync();
            await transaction.CommitAsync();
            return true;

        }
        catch (Exception)
        {
            await transaction.RollbackAsync();
            return false;
        }
    }

    public bool RemoveById(Guid id)
    {
        using var transaction = _context.Database.BeginTransaction();
        try
        {
            var entityExist = _context.Set<T>().Find(id);
            if (entityExist == null)
            {
                return false;
            }

            _context.Set<T>().Remove(entityExist);
            _context.SaveChanges();
            transaction.Commit();
            return true;
        }
        catch (Exception)
        {
            transaction.Rollback();
            return false;
        }
    }

    public async Task<bool> RemoveByIdAsync(Guid id)
    {
        await using var transaction = await _context.Database.BeginTransactionAsync();
        try
        {
            var entityExist = await _context.Set<T>().FindAsync(id);
            if (entityExist == null)
            {
                return false;
            }
            _context.Set<T>().Remove(entityExist);
            await _context.SaveChangesAsync();
            await transaction.CommitAsync();
            return true;
        }
        catch (Exception)
        {
            await transaction.RollbackAsync();
            return false;
        }
    }

    public bool Remove(T entity)
    {
        using var transaction = _context.Database.BeginTransaction();
        try
        {
            _context.Set<T>().Remove(entity);
            _context.SaveChanges();
            transaction.Commit();
            return true;
        }
        catch (Exception)
        {
            transaction.Rollback();
            return false;
        }
    }

    public async Task<bool> RemoveAsync(T entity)
    {
        await using var transaction = await _context.Database.BeginTransactionAsync();
        try
        {
            _context.Set<T>().Remove(entity);
            await _context.SaveChangesAsync();
            await transaction.CommitAsync();
            return true;
        }
        catch (Exception)
        {
            await transaction.RollbackAsync();
            return false;
        }
    }

    public bool RemoveRange(IEnumerable<T> entites)
    {
        using var transaction = _context.Database.BeginTransaction();
        try
        {
            _context.Set<T>().RemoveRange(entites);
            _context.SaveChanges();
            transaction.Commit();
            return true;
        }
        catch (Exception)
        {
            transaction.Rollback();
            return false;
        }
    }

    public async Task<bool> RemoveRangeAsync(IEnumerable<T> entities)
    {
        await using var transaction = await _context.Database.BeginTransactionAsync();
        try
        {
            _context.Set<T>().RemoveRange(entities);
            await _context.SaveChangesAsync();
            await transaction.CommitAsync();
            return true;
        }
        catch (Exception)
        {
            await transaction.RollbackAsync();
            return false;
        }
    }
}