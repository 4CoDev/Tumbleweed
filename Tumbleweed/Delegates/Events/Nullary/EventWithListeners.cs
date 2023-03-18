using Tumbleweed.Delegates.Actions.Nullary;

namespace Tumbleweed.Delegates.Events.Nullary;

public sealed class EventWithListeners : INullaryEvent
{
	public EventWithListeners
	(
		IDictionary<Object, INullaryAction> listeners
	)
	{
		Listeners = listeners;
	}
	
	public IDictionary<Object, INullaryAction> Listeners { get; }
}