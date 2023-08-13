using List = Tumbleweed.Event.Listening.List;
using Procedure = Tumbleweed.Subroutine.Procedure.Nullary;

namespace DotGod.Engine.Iteration.Event.Group.Listening.List;

public interface Any
{
	List::Any<Procedure::Any> Graphical { get; }
	
	List::Any<Procedure::Any> Physical { get; }
}