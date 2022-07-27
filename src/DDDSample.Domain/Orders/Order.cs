namespace DDDSample.Domain.Orders;

using DDDSample.Domain.Orders.OrderItems;
using MediatR;

public class Order : IAggregateRoot
{
    public Guid Id { get; }
    public DateTime OrderDate { get; private set; }
    public String Description { get; private set; }
    public String BuyerId { get; private set; }
    public Address Address { get; private set; }
    public ICollection<OrderItem> OrderItems { get; private set; }
    public ICollection<INotification> Events { get; private set; }

    public Order(Guid id, DateTime orderDate, String description, String buyerId, Address address)
    {
        if (orderDate < DateTime.Now)
        {
            throw new OrderDateException();
        }

        Id = id;
        OrderDate = orderDate;
        Description = description ?? String.Empty;
        BuyerId = buyerId ?? String.Empty;
        Address = address ?? throw new ArgumentNullException(nameof(address));

        OrderItems = new List<OrderItem>();

        AddEvent(new OrderStartedEvent(Guid.NewGuid().ToString(), this));
    }

    public void AddOrderItem(OrderItem orderItem)
    {
        OrderItems.Add(orderItem);
    }

    public void AddEvent(INotification notification)
    {
        Events ??= new List<INotification>();

        Events.Add(notification);
    }
}
