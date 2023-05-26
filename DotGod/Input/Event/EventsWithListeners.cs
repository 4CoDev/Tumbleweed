using Tumbleweed.Event.Nullary;
using Tumbleweed.Subroutine.Action.Nullary;

namespace DotGod.Input.Event;

public sealed class EventsWithListeners : EventsEnvelope
{
	public EventsWithListeners
	(
		IDictionary<Object, IAction> handled,
		IDictionary<Object, IAction> unhandled
	) : base
	(
		new EventsWithSpecific(
			new EventWithListeners(handled),
			new EventWithListeners(unhandled))
	)
	{
	}
}