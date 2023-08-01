using Tumbleweed.Event.Listening.List;
using NullaryProcedure = Tumbleweed.Subroutine.Procedure.Nullary;

namespace DotGod.Iteration.Event.Subscription;

public interface Any
{
	Any<NullaryProcedure.Any> Graphical { get; }
	
	Any<NullaryProcedure.Any> Physical { get; }
}