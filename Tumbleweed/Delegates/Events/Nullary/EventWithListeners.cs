using Tumbleweed.Delegates.Actions.Nullary;

namespace Tumbleweed.Delegates.Events.Nullary;

public sealed class EventWithListeners : IEvent
{
	public EventWithListeners
	(
		IDictionary<Object, IAction> listeners
	)
	{
		Listeners = listeners;
	}
	
	public IDictionary<Object, IAction> Listeners { get; }
}