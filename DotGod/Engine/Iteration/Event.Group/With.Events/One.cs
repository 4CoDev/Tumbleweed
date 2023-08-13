using Event = Tumbleweed.Event;
using Procedure = Tumbleweed.Subroutine.Procedure.Nullary;

namespace DotGod.Engine.Iteration.Event.Group.With.Events;

public sealed class One : Any
{
	public One
	(
		Event::Any<Procedure::Any> graphical,
		Event::Any<Procedure::Any> physical
	)
	{
		Graphical = graphical;
		Physical = physical;
	}
	
	public Event::Any<Procedure::Any> Graphical { get; }

	public Event::Any<Procedure::Any> Physical { get; }
}