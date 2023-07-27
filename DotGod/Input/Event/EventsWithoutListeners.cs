using Tumbleweed.Event.Nullary;

namespace DotGod.Input.Event;

public sealed class EventsWithoutListeners : EventsEnvelope
{
	public EventsWithoutListeners() : base
	(
		new EventsWithSpecific(
			new Empty(),
			new Empty())
	)
	{
	}
}