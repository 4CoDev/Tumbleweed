using Engine = DotGod.Engine;
using Iteration = DotGod.Engine.Iteration;
using Input = DotGod.Engine.Input;

namespace DotGod.Engine.Event.Group;

public abstract class Envelope : Engine::Event.Group.Any
{
	protected Envelope(Engine::Event.Group.Any group) =>
		this.group = group;
	
	public Iteration::Event.Group.Any Iteration =>
		group.Iteration;

	public Input::Event.Group.Any Input =>
		group.Input;

	private readonly Engine::Event.Group.Any group;
}