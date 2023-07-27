using Tumbleweed.Event.Nullary;

namespace DotGod.Iteration.Event;

public sealed class EventsWithoutListeners : Envelope
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