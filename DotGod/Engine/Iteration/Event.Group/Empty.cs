using DotGod.Engine.Iteration.Event.Group.With.Events;
using Event = Tumbleweed.Event;

namespace DotGod.Engine.Iteration.Event.Group;

public sealed class Empty : Envelope
{
	public Empty() : base
	(
		new One(
			new Event::Nullary.Empty(),
			new Event::Nullary.Empty())
	)
	{
	}
}