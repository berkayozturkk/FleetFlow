namespace FleetFlow.Application.Abstractions;

public interface IRepository<TEntity, TId> where TEntity : class 
{
    Task<List<TEntity>> GetAllAsync();
    Task<TEntity> GetByIdAsync(TId id);
    Task CreateAsync(TEntity entity);
    Task UpdateAsync(TEntity entity);
    Task DeleteAsync(TEntity entity);
}
