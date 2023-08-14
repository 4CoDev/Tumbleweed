using Iteration = DotGod.Engine.Iteration;
using Engine = DotGod.Engine;

namespace DotGod.Engine.Event.Group.Member;

public sealed class Iteration : Iteration::Event.Group.Envelope
{
	public Iteration(Engine::Event.Group.Any group) : base
	(
		new Iteration::Event.Group.Function.Result.One(
			() => group.Iteration)
	)
	{
	}
}