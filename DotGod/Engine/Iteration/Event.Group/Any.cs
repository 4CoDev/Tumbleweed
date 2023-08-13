using Event = Tumbleweed.Event;
using Procedure = Tumbleweed.Subroutine.Procedure.Nullary;

namespace DotGod.Engine.Iteration.Event.Group;

public interface Any
{
	Event::Any<Procedure::Any> Graphical { get; }
	
	Event::Any<Procedure::Any> Physical { get; }
}