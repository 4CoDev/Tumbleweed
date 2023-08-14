using Engine = DotGod.Engine;
using Iteration = DotGod.Engine.Iteration;
using Input = DotGod.Engine.Input;

namespace DotGod.Engine.Event.Group;

public sealed class Empty : Engine::Event.Group.Envelope
{
	public Empty() : base
	(
		new Engine::Event.Group.With.Groups.One(
			new Iteration::Event.Group.Empty(),
			new Input::Event.Group.Empty())
	)
	{
	}
}