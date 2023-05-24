using Tumbleweed.Events.Subscriptions;
using Tumbleweed.Subroutines.Actions.Nullary;

namespace DotGod.Input.Events.Subscriptions;

public abstract class SubscriptionsEnvelope : ISubscriptions
{
	protected SubscriptionsEnvelope(ISubscriptions events) =>
		this.events = events;

	public ISubscription<IAction> Handled => events.Handled;

	public ISubscription<IAction> Unhandled => events.Unhandled;

	private readonly ISubscriptions events;
}