namespace JobProfileMaker.core.Contracts.Repository;

public interface IRepositoryAsync<T> where T : class
{
    Task<IEnumerable<T>> GetAllAsync();
    Task<T> GetByIdAsync(int id);
    int InsertAsync(T entity);
    int UpdateAsync(T entity);
    int DeleteAsync(int id);
}