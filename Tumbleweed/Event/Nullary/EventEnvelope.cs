using Tumbleweed.Event.Subscription;
using Tumbleweed.Subroutine.Nullary.Action;

namespace Tumbleweed.Event.Nullary;

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