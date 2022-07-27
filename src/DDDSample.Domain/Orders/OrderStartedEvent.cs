namespace DDDSample.Domain.Orders;

using MediatR;

public class OrderStartedEvent : INotification
{
    public String BuyerId { get; private set; }
    public Order? Order { get; private set; }

    public OrderStartedEvent(String buyerId, Order? order)
    {
        this.BuyerId = buyerId ?? throw new ArgumentNullException(nameof(buyerId));
        this.Order = order;
    }
}
