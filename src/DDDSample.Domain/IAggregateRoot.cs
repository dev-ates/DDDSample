namespace DDDSample.Domain;

using MediatR;

public interface IAggregateRoot : IEntity
{
    public ICollection<INotification> Events { get; }

    public void AddEvent(INotification notification);
}
