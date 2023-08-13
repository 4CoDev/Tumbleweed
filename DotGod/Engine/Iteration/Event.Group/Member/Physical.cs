using Event = Tumbleweed.Event.Nullary;

namespace DotGod.Engine.Iteration.Event.Group.Member;

public sealed class Physical : Event::Envelope
{
	public Physical(Any both) : base
	(
		new Event::Function.Result.Actual(
			() => both.Physical)
	)
	{
	}
}