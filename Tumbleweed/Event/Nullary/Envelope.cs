using NullaryEvent = Tumbleweed.Event.Nullary;
using NullaryProcedure = Tumbleweed.Subroutine.Procedure.Nullary;

namespace Tumbleweed.Event.Nullary;

public abstract class Envelope : NullaryEvent.Any
{
	protected Envelope(NullaryEvent.Any @event) =>
		this.@event = @event;

	public Subscription.Any<NullaryProcedure.Any> Subscription =>
		@event.Subscription;

	public void Invoke() =>
		@event.Invoke();
	
	private readonly NullaryEvent.Any @event;
}