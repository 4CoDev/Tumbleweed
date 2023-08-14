using Godot = Godot;
using Engine = DotGod.Engine;
using System = System;
using Procedure = Tumbleweed.Subroutine.Procedure.Binary;

namespace DotGod.Application.Root.Node.With.Event.Group;

public class Empty : Specific
{
	public Empty
	(
		System::Action<Godot::Node, Engine::Event.Group.Any> action
	) : this
	(
		new Procedure::From.System
			<Godot::Node, Engine::Event.Group.Any>
			(action))
	{
	}
	
	public Empty
	(
		Procedure::Any<Godot::Node, Engine::Event.Group.Any> action
	) : base
	(
		new Engine::Event.Group.Empty(),
		action
	)
	{
	}
}