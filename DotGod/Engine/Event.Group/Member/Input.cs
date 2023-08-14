using Input = DotGod.Engine.Input;
using Engine = DotGod.Engine;

namespace DotGod.Engine.Event.Group.Member;

public sealed class Input : Input::Event.Group.Envelope
{
	public Input(Engine::Event.Group.Any group) : base
	(
		new Input::Event.Group.Function.Result.One(
			() => group.Input)
	)
	{
	}
}