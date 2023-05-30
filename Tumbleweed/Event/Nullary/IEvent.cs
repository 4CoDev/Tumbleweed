using Tumbleweed.Event.Subscription;
using Tumbleweed.Subroutine.Nullary.Action;

namespace Tumbleweed.Event.Nullary;

public interface IEvent
{
	ISubscription<IAction> Subscription { get; }
	
	void Invoke();
}