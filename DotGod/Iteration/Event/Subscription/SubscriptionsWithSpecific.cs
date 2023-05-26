using Tumbleweed.Event.Subscription;
using Tumbleweed.Subroutine.Action.Nullary;

namespace DotGod.Iteration.Event.Subscription;

public sealed class SubscriptionsWithSpecific : ISubscriptions
{
	public SubscriptionsWithSpecific
	(
		ISubscription<IAction> graphical,
		ISubscription<IAction> physical
	)
	{
		Graphical = graphical;
		Physical = physical;
	}
	
	public ISubscription<IAction> Graphical { get; }

	public ISubscription<IAction> Physical { get; }
}