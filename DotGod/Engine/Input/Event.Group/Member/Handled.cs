using Event = Tumbleweed.Event.Nullary;

namespace DotGod.Engine.Input.Event.Group.Member;

public sealed class Handled : Event::Envelope
{
	public Handled(Any both) : base
	(
		new Event::Function.Result.Actual(
			() => both.Handled)
	)
	{
	}
}