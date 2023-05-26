using Tumbleweed.Event.Subscription;
using Tumbleweed.Subroutine.Action.Nullary;

namespace Tumbleweed.Event.Nullary;

public interface IEvent
{
	ISubscription<IAction> Subscription { get; }
	
	void Invoke();
}