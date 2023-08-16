using Godot = Godot;
using Engine = DotGod.Engine;
using System = System;
using Procedure = Tumbleweed.Subroutine.Procedure;
using Iteration = DotGod.Engine.Iteration;
using Input = DotGod.Engine.Input;

namespace DotGod.Application.Root.Node.With.Event.Group;

public class Specific : Godot::Node
{
	public Specific
	(
		Engine::Event.Group.Any group,
		System::Action<Godot::Node, Engine::Event.Group.Any> action
	) : this
	(
		group,
		new Procedure::Binary.From.System
			<Godot::Node, Engine::Event.Group.Any>
			(action))
	{
	}
	
	public Specific
	(
		Engine::Event.Group.Any group,
		Procedure::Binary.Any<Godot::Node, Engine::Event.Group.Any> action
	)
	{
		iteration = new Engine::Event.Group.Member.Iteration(group);
		input = new Engine::Event.Group.Member.Input(group);
		this.action = action;
		this.group = group;
	}

	public sealed override void _Process(System::Double delta) =>
		iteration.Graphical.Invoke();

	public sealed override void _PhysicsProcess(System::Double delta) =>
		iteration.Physical.Invoke();

	private readonly Iteration::Event.Group.Any iteration;

	public sealed override void _Input(Godot::InputEvent @event) =>
		input.Handled.Invoke();

	public sealed override void _UnhandledInput(Godot::InputEvent @event) =>
		input.Unhandled.Invoke();

	private readonly Input::Event.Group.Any input;

	public sealed override void _Ready() =>
		action.InvokeWith(this, group);

	private readonly
		Procedure::Binary.Any<Godot::Node, Engine::Event.Group.Any>
		action;
	
	private readonly Engine::Event.Group.Any group;
}