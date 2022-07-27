namespace DDDSample.Application.Orders;

using System.Threading;
using System.Threading.Tasks;
using DDDSample.Application.Contracts;
using DDDSample.Application.Contracts.Buyers;
using DDDSample.Domain.Orders;
using MediatR;

public class OrderStartedEventHandler : INotificationHandler<OrderStartedEvent>
{
    private readonly IBuyerRepository buyerRepository;
    private readonly IUnitOfWork unitOfWork;

    public OrderStartedEventHandler(IBuyerRepository buyerRepository, IUnitOfWork unitOfWork)
    {
        this.buyerRepository = buyerRepository;
        this.unitOfWork = unitOfWork;
    }

    public async Task Handle(OrderStartedEvent notification, CancellationToken cancellationToken)
    {
        if (notification == null && notification?.Order == null)
        {
            await Task.CompletedTask;
            return;
        }

        if (Guid.Parse(notification.BuyerId) == Guid.Empty)
        {
            throw new Exception("BuyerId empty!");
        }

        _ = await buyerRepository.GetById(Guid.Parse(notification.BuyerId))
            ?? throw new Exception("Buyer not found!");
    }
}
