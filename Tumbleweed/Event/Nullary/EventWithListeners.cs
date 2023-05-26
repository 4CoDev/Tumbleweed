using Tumbleweed.Event.Nullary._Action;
using Tumbleweed.Event.Subscription;
using Tumbleweed.Subroutine.Action.Nullary;

namespace Tumbleweed.Event.Nullary;

public sealed class EventWithListeners : EventEnvelope
{
	public EventWithListeners
	(
		IDictionary<Object, IAction> listeners
	) : base
	(
		new EventWithValues(
			new SubscriptionWithDictionary<IAction>(listeners),
			new ReactionOfListeners(listeners))
	)
	{
	}
}