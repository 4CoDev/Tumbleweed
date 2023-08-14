using Engine = DotGod.Engine;
using Input = DotGod.Engine.Input;
using Iteration = DotGod.Engine.Iteration;

namespace DotGod.Engine.Event.Group.With.Groups;

public sealed class One : Engine::Event.Group.Any
{
	public One
	(
		Iteration::Event.Group.Any iteration,
		Input::Event.Group.Any input
	)
	{
		Iteration = iteration;
		Input = input;
	}
	
	public Iteration.Event.Group.Any Iteration { get; }
	
	public Input.Event.Group.Any Input { get; }
}