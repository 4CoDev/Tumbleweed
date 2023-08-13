using Event = Tumbleweed.Event.Nullary;

namespace DotGod.Engine.Input.Event.Group.Member;

public sealed class Unhandled : Event::Envelope
{
	public Unhandled(Any both) : base
	(
		new Event::Function.Result.Actual(
			() => both.Unhandled)
	)
	{
	}
}