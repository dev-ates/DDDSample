namespace DDDSample.Domain.Orders.OrderItems;

public class OrderItem : IEntity
{
    public Guid Id { get; private set; }
    public Int32 Quantity { get; private set; }
    public Decimal Price { get; private set; }
    public String ProductId { get; private set; }

    public OrderItem(Guid id, Int32 quantity, Decimal price, String productId)
    {
        this.Id = id;
        this.Quantity = quantity;
        this.Price = price;
        this.ProductId = productId ?? throw new ArgumentNullException(nameof(productId));
    }
}
