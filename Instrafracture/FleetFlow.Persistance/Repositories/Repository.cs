using FleetFlow.Application.Abstractions;
using FleetFlow.Domain.Abstraction;
using FleetFlow.Persistance.Context;
using Microsoft.EntityFrameworkCore;

namespace FleetFlow.Persistance.Repositories;

public class Repository<TEntity, TId> : IRepository<TEntity, TId> 
    where TEntity : Entity<TId>
{
    private readonly BaseDbContext _dbContext;

    public Repository(BaseDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task CreateAsync(TEntity entity)
    {
        entity.CreatedDate = DateTime.Now;
        await _dbContext.Set<TEntity>().AddAsync(entity);
        await _dbContext.SaveChangesAsync();
    }

    public async Task DeleteAsync(TEntity entity)
    {
        _dbContext.Set<TEntity>().Remove(entity);
        await _dbContext.SaveChangesAsync();
    }

    public async Task<List<TEntity>> GetAllAsync()
    {
        return await _dbContext.Set<TEntity>().ToListAsync();
    }

    public async Task<TEntity> GetByIdAsync(TId id)
    {
        return await _dbContext.Set<TEntity>().FindAsync(id);
    }

    public async Task UpdateAsync(TEntity entity)
    {
        entity.UpdatedDate = DateTime.Now;
        _dbContext.Set<TEntity>().Update(entity);
        await _dbContext.SaveChangesAsync();
    }
}
