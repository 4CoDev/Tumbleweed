using Tumbleweed.Event.Nullary;
using Tumbleweed.Subroutine.Nullary.Action;

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