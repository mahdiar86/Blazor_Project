using Blazor_Project.Data.Models;

namespace Blazor_Project.Data.Repository;


public interface IGenericRepository<TEntity> : IAsyncDisposable where TEntity : BaseEntity
{
    IQueryable<TEntity> GetQuery();

    Task AddEntity(TEntity entity);

    Task<TEntity> GetEntityById(long entityId);

    Task AddRangeEntities(List<TEntity> entities);

    void EditEntity(TEntity entity);

    void DeleteEntity(TEntity entity);

    Task DeleteEntity(long entityId);

    void DeletePermanent(TEntity entity);

    Task DeletePermanent(long entityId);

    Task SaveChanges();
}