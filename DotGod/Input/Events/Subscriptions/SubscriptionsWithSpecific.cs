using Tumbleweed.Events.Subscriptions;
using Tumbleweed.Subroutines.Actions.Nullary;

namespace DotGod.Input.Events.Subscriptions;

public sealed class SubscriptionsWithSpecific : ISubscriptions
{
	public SubscriptionsWithSpecific
	(
		ISubscription<IAction> handled,
		ISubscription<IAction> unhandled
	)
	{
		Handled = handled;
		Unhandled = unhandled;
	}


	public ISubscription<IAction> Handled { get; }

	public ISubscription<IAction> Unhandled { get; }
}