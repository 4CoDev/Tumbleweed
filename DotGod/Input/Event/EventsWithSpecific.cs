using Tumbleweed.Event.Nullary;

namespace DotGod.Input.Event;

public sealed class EventsWithSpecific : IEvents
{
	public EventsWithSpecific(Any handled, Any unhandled)
	{
		Handled = handled;
		Unhandled = unhandled;
	}

	public Any Handled { get; }

	public Any Unhandled { get; }
}