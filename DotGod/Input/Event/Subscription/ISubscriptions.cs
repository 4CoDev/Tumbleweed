using Tumbleweed.Event.Subscription;
using Tumbleweed.Subroutine.Action.Nullary;

namespace DotGod.Input.Event.Subscription;

public interface ISubscriptions
{
	ISubscription<IAction> Handled { get; }
	
	ISubscription<IAction> Unhandled { get; }
}