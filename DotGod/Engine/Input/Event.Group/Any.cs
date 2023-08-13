using Event = Tumbleweed.Event;
using Procedure = Tumbleweed.Subroutine.Procedure.Nullary;

namespace DotGod.Engine.Input.Event.Group;

public interface Any
{
	Event::Any<Procedure::Any> Handled { get; }
	
	Event::Any<Procedure::Any> Unhandled { get; }
}