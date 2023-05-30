using Tumbleweed.Event.Subscription;
using Tumbleweed.Subroutine.Nullary.Action;

namespace DotGod.Iteration.Event.Subscription;

public interface ISubscriptions
{
	ISubscription<IAction> Graphical { get; }
	
	ISubscription<IAction> Physical { get; }
}