namespace DDDSample.Domain.Orders;

public class OrderDateException : Exception
{
    public OrderDateException() : base("OrderDate must be greater than now!")
    {
    }
}
