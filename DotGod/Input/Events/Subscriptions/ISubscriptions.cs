using Tumbleweed.Events.Subscriptions;
using Tumbleweed.Subroutines.Actions.Nullary;

namespace DotGod.Input.Events.Subscriptions;

public interface ISubscriptions
{
	ISubscription<IAction> Handled { get; }
	
	ISubscription<IAction> Unhandled { get; }
}