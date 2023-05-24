using Tumbleweed.Events.Nullary.Actions;
using Tumbleweed.Events.Subscriptions;
using Tumbleweed.Subroutines.Actions.Nullary;

namespace Tumbleweed.Events.Nullary;

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