using Tumbleweed.Events.Subscriptions;
using Tumbleweed.Subroutines.Actions.Nullary;

namespace DotGod.Iteration.Events.Subscriptions;

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