namespace DDDSample.Domain.Buyers;

using System.Collections.Generic;
using MediatR;

public class Buyer : IAggregateRoot
{
    public Guid Id { get; set; }
    public string Username { get; set; }
    public ICollection<INotification> Events { get; private set; }

    public Buyer(Guid id, String username)
    {
        Id = id;
        Username = username ?? throw new ArgumentNullException(nameof(username));
    }

    public void AddEvent(INotification notification)
    {
        Events ??= new List<INotification>();
        Events.Add(notification);
    }
}
