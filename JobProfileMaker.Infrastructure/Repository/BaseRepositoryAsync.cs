using System.Data.Entity;
using JobProfileMaker.core.Contracts.Repository;
using JobProfileMaker.Infrastructure.Data;
using EntityState = Microsoft.EntityFrameworkCore.EntityState;

namespace JobProfileMaker.Infrastructure.Repository;

public class BaseRepositoryAsync<T> : IRepositoryAsync<T> where T : class
{
    private readonly JobProfileMakerDbContext _dbContext;
    public BaseRepositoryAsync(JobProfileMakerDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<IEnumerable<T>> GetAllAsync()
    {
        return await _dbContext.Set<T>().ToListAsync();
    }

    public async Task<T> GetByIdAsync(int id)
    {
       return await _dbContext.Set<T>().FindAsync(id);
    }

    public async Task<int> InsertAsync(T entity)
    {
        await _dbContext.Set<T>().AddAsync(entity);
        return await _dbContext.SaveChangesAsync();
    }

    public async Task<int> UpdateAsync(T entity)
    {
        _dbContext.Set<T>().Entry(entity).State = EntityState.Modified;
        return await _dbContext.SaveChangesAsync();
    }

    public async Task<int> DeleteAsync(int id)
    {
        var entity = await GetByIdAsync(id);
        if (entity != null)
        {
            _dbContext.Set<T>().Remove(entity);
            return await _dbContext.SaveChangesAsync();
        }

        return -1;
    }
}