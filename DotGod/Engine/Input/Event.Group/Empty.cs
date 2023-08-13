using DotGod.Engine.Input.Event.Group.With.Events;
using Event = Tumbleweed.Event;

namespace DotGod.Engine.Input.Event.Group;

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