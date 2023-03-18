using Tumbleweed.Delegates.Actions.Nullary;

namespace Tumbleweed.Delegates.Events.Nullary;

public sealed class EventWithValues : INullaryEvent
{
	public EventWithValues
	(
		IDictionary<Object, INullaryAction> listeners
	)
	{
		Listeners = listeners;
	}
	
	public IDictionary<Object, INullaryAction> Listeners { get; }
}