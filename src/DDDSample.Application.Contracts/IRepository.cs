namespace DDDSample.Application.Contracts;

using DDDSample.Domain;

public interface IRepository<TEntity> where TEntity : IEntity
{
    public Task<TEntity> GetById(Guid id);
    public Task<TEntity> Add(TEntity entity);
}
