using Tumbleweed.Events.Nullary;
using Tumbleweed.Subroutines.Actions.Nullary;

namespace DotGod.Iteration.Events;

public sealed class EventsWithoutListeners : EventsEnvelope
{
	public EventsWithoutListeners() : base
	(
		new EventsWithSpecific(
			new EventWithoutListeners(),
			new EventWithoutListeners())
	)
	{
	}
}