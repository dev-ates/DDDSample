namespace DDDSample.Application.Contracts;

public interface IUnitOfWork : IDisposable
{
    public Task Commit();
    public Task Rollback();
}
