using Tumbleweed.Event.Nullary;

namespace DotGod.Iteration.Event;

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