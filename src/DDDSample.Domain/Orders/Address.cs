namespace DDDSample.Domain.Orders;

public record Address
{
    public Address(String country, String city)
    {
        this.Country = country ?? throw new ArgumentNullException(nameof(country));
        this.City = city ?? throw new ArgumentNullException(nameof(city));
    }

    public String Country { get; private set; }
    public String City { get; private set; }
}
