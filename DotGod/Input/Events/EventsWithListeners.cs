using Tumbleweed.Events.Nullary;
using Tumbleweed.Subroutines.Actions.Nullary;

namespace DotGod.Input.Events;

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