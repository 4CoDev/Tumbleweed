using Event = Tumbleweed.Event.Nullary;

namespace DotGod.Engine.Iteration.Event.Group.Member;

public sealed class Graphical : Event::Envelope
{
	public Graphical(Any both) : base
	(
		new Event::Function.Result.Actual(
			() => both.Graphical)
	)
	{
	}
}