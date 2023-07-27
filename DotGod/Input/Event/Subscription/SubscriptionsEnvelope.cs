using Tumbleweed.Event.Subscription;
using Tumbleweed.Subroutine.Procedure.Nullary;

namespace DotGod.Input.Event.Subscription;

public abstract class SubscriptionsEnvelope : ISubscriptions
{
	protected SubscriptionsEnvelope(ISubscriptions events) =>
		this.events = events;

	public Any<Any> Handled => events.Handled;

	public Any<Any> Unhandled => events.Unhandled;

	private readonly ISubscriptions events;
}