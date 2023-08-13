using List = Tumbleweed.Event.Listening.List;
using Procedure = Tumbleweed.Subroutine.Procedure.Nullary;

namespace DotGod.Engine.Iteration.Event.Group.Listening.List.With.Lists;

public sealed class One : Any
{
	public One
	(
		List::Any<Procedure::Any> graphical,
		List::Any<Procedure::Any> physical
	)
	{
		Graphical = graphical;
		Physical = physical;
	}
	
	public List::Any<Procedure::Any> Graphical { get; }

	public List::Any<Procedure::Any> Physical { get; }
}