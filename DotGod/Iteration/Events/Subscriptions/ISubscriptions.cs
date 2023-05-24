using Tumbleweed.Events.Subscriptions;
using Tumbleweed.Subroutines.Actions.Nullary;

namespace DotGod.Iteration.Events.Subscriptions;

public interface ISubscriptions
{
	ISubscription<IAction> Graphical { get; }
	
	ISubscription<IAction> Physical { get; }
}