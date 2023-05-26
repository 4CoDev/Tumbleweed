using Tumbleweed.Event.Nullary;
using Tumbleweed.Subroutine.Action.Nullary;

namespace DotGod.Iteration.Event;

public sealed class EventsWithListeners : EventsEnvelope
{
	public EventsWithListeners
	(
		IDictionary<Object, IAction> graphical,
		IDictionary<Object, IAction> physical
	) : base
	(
		new EventsWithSpecific(
			new EventWithListeners(graphical),
			new EventWithListeners(physical))
	)
	{
	}
}