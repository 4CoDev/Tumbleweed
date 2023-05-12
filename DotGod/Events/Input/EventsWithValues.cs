using Tumbleweed.Events;
using Tumbleweed.Subroutines.Actions.Nullary;

namespace DotGod.Events.Input;

public sealed class EventsWithValues : IInputEvents
{
	public EventsWithValues
	(
		IEvent<IAction> handled,
		IEvent<IAction> unhandled
	)
	{
		Handled = handled;
		Unhandled = unhandled;
	}


	public IEvent<IAction> Handled { get; }

	public IEvent<IAction> Unhandled { get; }
}