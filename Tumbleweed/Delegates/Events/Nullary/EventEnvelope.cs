using Tumbleweed.Delegates.Actions.Nullary;

namespace Tumbleweed.Delegates.Events.Nullary;

public abstract class EventEnvelope : IEvent
{
	protected EventEnvelope(IEvent @event) =>
		this.@event = @event;

	public override Boolean Equals(Object? @object) =>
		@event.Equals(@object);

	public override Int32 GetHashCode() =>
		@event.GetHashCode();

	public override String? ToString() =>
		@event.ToString();

	public IDictionary<Object, IAction> Listeners =>
		@event.Listeners;

	private readonly IEvent @event;
}