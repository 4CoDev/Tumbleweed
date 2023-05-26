using Tumbleweed.Event.Subscription;
using Tumbleweed.Subroutine.Action.Nullary;

namespace DotGod.Iteration.Event.Subscription;

public interface ISubscriptions
{
	ISubscription<IAction> Graphical { get; }
	
	ISubscription<IAction> Physical { get; }
}