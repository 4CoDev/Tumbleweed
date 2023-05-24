using Tumbleweed.Events.Nullary;
using Tumbleweed.Subroutines.Actions.Nullary;

namespace DotGod.Iteration.Events;

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