namespace DDDSample.Infrastructure;

using System;
using System.Threading.Tasks;
using DDDSample.Application.Contracts;
using DDDSample.Domain;

public class FakeRepository<TEntity> : IRepository<TEntity> where TEntity : IEntity
{
    public Task<TEntity> Add(TEntity entity)
    {
        throw new NotImplementedException();
    }

    public Task<TEntity> GetById(Guid id)
    {
        throw new NotImplementedException();
    }
}
