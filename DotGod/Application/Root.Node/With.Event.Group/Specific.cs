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
	) : this
	(
		new Engine::Event.Group.Member.Iteration(group),
		new Engine::Event.Group.Member.Input(group),
		action
	)
	{
	}
	
	public Specific
	(
		Iteration::Event.Group.Any iteration,
		Input::Event.Group.Any input,
		Procedure::Binary.Any<Godot::Node, Engine::Event.Group.Any> action)
	{
		this.iteration = iteration;
		this.input = input;
	}

	public override void _Process(System::Double delta) =>
		iteration.Graphical.Invoke();

	public override void _PhysicsProcess(System::Double delta) =>
		iteration.Physical.Invoke();

	private readonly Iteration::Event.Group.Any iteration;

	public override void _Input(Godot::InputEvent @event) =>
		input.Handled.Invoke();

	public override void _UnhandledInput(Godot::InputEvent @event) =>
		input.Unhandled.Invoke();

	private readonly Input::Event.Group.Any input;
}