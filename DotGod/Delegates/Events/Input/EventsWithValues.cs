using Tumbleweed.Delegates.Events.Nullary;

namespace DotGod.Delegates.Events.Input;

public sealed class EventsWithValues : IInputEvents
{
	public EventsWithValues
	(
		IEvent handled,
		IEvent unhandled
	)
	{
		Handled = handled;
		Unhandled = unhandled;
	}


	public IEvent Handled { get; }

	public IEvent Unhandled { get; }
}