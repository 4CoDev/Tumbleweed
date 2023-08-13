using Event = Tumbleweed.Event;
using Procedure = Tumbleweed.Subroutine.Procedure.Nullary;

namespace DotGod.Engine.Input.Event.Group.With.Events;

public sealed class One : Any
{
	public One
	(
		Event::Any<Procedure::Any> handled,
		Event::Any<Procedure::Any> unhandled)
	{
		Handled = handled;
		Unhandled = unhandled;
	}

	public Event::Any<Procedure::Any> Handled { get; }

	public Event::Any<Procedure::Any> Unhandled { get; }
}