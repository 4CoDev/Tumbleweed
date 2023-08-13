using Tumbleweed.Event.Listening.List;

namespace DotGod.Engine.Input.Event.Group.Listening.List.With.Lists;

public sealed class One : Any
{
	public One
	(
		Any<Tumbleweed.Subroutine.Procedure.Nullary.Any> handled,
		Any<Tumbleweed.Subroutine.Procedure.Nullary.Any> unhandled
	)
	{
		Handled = handled;
		Unhandled = unhandled;
	}


	public Any<Tumbleweed.Subroutine.Procedure.Nullary.Any> Handled { get; }

	public Any<Tumbleweed.Subroutine.Procedure.Nullary.Any> Unhandled { get; }
}