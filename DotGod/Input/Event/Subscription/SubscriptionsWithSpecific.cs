using Tumbleweed.Event.Subscription;
using Tumbleweed.Subroutine.Nullary.Action;

namespace DotGod.Input.Event.Subscription;

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