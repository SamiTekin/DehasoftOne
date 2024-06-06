namespace DehasoftOne.Data.Generics;

public interface IGenericRepository<TEntity>
{
    Task<TEntity> AddAsync(TEntity entity);
    Task DeleteAsync(Guid id);
    IQueryable<TEntity> GetAll();
    Task<TEntity> GetByIdAsync(Guid id);
    Task UpdateAsync(List<TEntity> entities);
    Task<TEntity> UpdateAsync(TEntity entity);
}