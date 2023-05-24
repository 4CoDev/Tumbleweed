using Tumbleweed.Events.Nullary;

namespace DotGod.Input.Events;

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