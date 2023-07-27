using Tumbleweed.Event.Nullary.With;
using Any = Tumbleweed.Subroutine.Procedure.Nullary.Any;

namespace DotGod.Input.Event;

public sealed class EventsWithListeners : EventsEnvelope
{
	public EventsWithListeners
	(
		IDictionary<Object, Any> handled,
		IDictionary<Object, Any> unhandled
	) : base
	(
		new EventsWithSpecific(
			new Listeners(handled),
			new Listeners(unhandled))
	)
	{
	}
}