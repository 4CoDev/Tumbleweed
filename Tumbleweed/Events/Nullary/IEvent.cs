using Tumbleweed.Events.Subscriptions;
using Tumbleweed.Subroutines.Actions.Nullary;

namespace Tumbleweed.Events.Nullary;

public interface IEvent
{
	ISubscription<IAction> Subscription { get; }
	
	void Invoke();
}