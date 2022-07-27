namespace DDDSample.Infrastructure.Buyers;

using System.Threading.Tasks;
using DDDSample.Application.Contracts.Buyers;
using DDDSample.Domain.Buyers;

public class FakeBuyerRepository : FakeRepository<Buyer>, IBuyerRepository
{
}
