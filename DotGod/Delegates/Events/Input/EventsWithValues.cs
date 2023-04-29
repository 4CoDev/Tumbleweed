using Tumbleweed.Delegates.Events.Nullary;

namespace DotGod.Delegates.Events.Input;

public sealed class EventsWithValues : IInputEvents
{
	public EventsWithValues
	(
		INullaryEvent handled,
		INullaryEvent unhandled
	)
	{
		Handled = handled;
		Unhandled = unhandled;
	}


	public INullaryEvent Handled { get; }

	public INullaryEvent Unhandled { get; }
}