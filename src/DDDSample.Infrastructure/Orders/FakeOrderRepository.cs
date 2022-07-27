namespace DDDSample.Infrastructure.Orders;

using System.Threading.Tasks;
using DDDSample.Application.Contracts.Orders;
using DDDSample.Domain.Buyers;
using DDDSample.Domain.Orders;

public class FakeOrderRepository : FakeRepository<Order>, IOrderRepository
{
}
