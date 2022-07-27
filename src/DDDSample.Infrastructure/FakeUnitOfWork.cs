namespace DDDSample.Infrastructure;

using System.Threading.Tasks;
using DDDSample.Application.Contracts;

public class FakeUnitOfWork : IUnitOfWork
{
    public async Task Commit()
    {
        await Task.CompletedTask;
    }

    public void Dispose()
    {
        // todo: dispose
    }

    public async Task Rollback()
    {
        await Task.CompletedTask;
    }
}
