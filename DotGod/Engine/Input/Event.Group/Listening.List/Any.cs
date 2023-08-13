using Tumbleweed.Event.Listening.List;

namespace DotGod.Engine.Input.Event.Group.Listening.List;

public interface Any
{
	Any<Tumbleweed.Subroutine.Procedure.Nullary.Any> Handled { get; }
	
	Any<Tumbleweed.Subroutine.Procedure.Nullary.Any> Unhandled { get; }
}