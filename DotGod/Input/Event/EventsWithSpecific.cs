using Tumbleweed.Event.Nullary;

namespace DotGod.Input.Event;

public sealed class EventsWithSpecific : IEvents
{
	public EventsWithSpecific(IEvent handled, IEvent unhandled)
	{
		Handled = handled;
		Unhandled = unhandled;
	}

	public IEvent Handled { get; }

	public IEvent Unhandled { get; }
}