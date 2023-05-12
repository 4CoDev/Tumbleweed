namespace Tumbleweed.Events;

public abstract class EventEnvelope<T> : IEvent<T>
{
	protected EventEnvelope(IEvent<T> @event) =>
		this.@event = @event;

	public override Boolean Equals(Object? @object) =>
		@event.Equals(@object);

	public override Int32 GetHashCode() =>
		@event.GetHashCode();

	public override String? ToString() =>
		@event.ToString();

	public void Unsubscribe(Object key) =>
		@event.Unsubscribe(key);

	public void Subscribe(Object key, T reaction) =>
		@event.Subscribe(key, reaction);

	private readonly IEvent<T> @event;
}