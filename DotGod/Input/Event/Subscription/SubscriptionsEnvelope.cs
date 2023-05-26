using Tumbleweed.Event.Subscription;
using Tumbleweed.Subroutine.Action.Nullary;

namespace DotGod.Input.Event.Subscription;

public abstract class SubscriptionsEnvelope : ISubscriptions
{
	protected SubscriptionsEnvelope(ISubscriptions events) =>
		this.events = events;

	public ISubscription<IAction> Handled => events.Handled;

	public ISubscription<IAction> Unhandled => events.Unhandled;

	private readonly ISubscriptions events;
}