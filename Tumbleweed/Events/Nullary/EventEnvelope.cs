using Tumbleweed.Events.Subscriptions;
using Tumbleweed.Subroutines.Actions.Nullary;

namespace Tumbleweed.Events.Nullary;

public abstract class EventEnvelope : IEvent
{
	protected EventEnvelope(IEvent @event) =>
		this.@event = @event;

	public ISubscription<IAction> Subscription =>
		@event.Subscription;

	public void Invoke() =>
		@event.Invoke();
	
	private readonly IEvent @event;
}