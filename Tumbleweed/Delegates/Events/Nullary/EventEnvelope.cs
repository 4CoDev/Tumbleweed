using Tumbleweed.Delegates.Actions.Nullary;

namespace Tumbleweed.Delegates.Events.Nullary;

public abstract class EventEnvelope : INullaryEvent
{
	protected EventEnvelope(INullaryEvent @event) =>
		this.@event = @event;

	public override Boolean Equals(Object? @object) =>
		@event.Equals(@object);

	public override Int32 GetHashCode() =>
		@event.GetHashCode();

	public override String? ToString() =>
		@event.ToString();

	public IDictionary<Object, INullaryAction> Listeners =>
		@event.Listeners;

	private readonly INullaryEvent @event;
}