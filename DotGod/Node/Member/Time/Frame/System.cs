using Property = Tumbleweed.Property.Output;
using System = System;
using Godot = Godot;

namespace DotGod.Node.Member.Time.Frame;

public sealed class System : Property::Envelope<System::Double>
{
	public System(Godot::Node node) : this
	(
		new Property::With.Value.One<Godot::Node>(node)
	)
	{
	}
	
	public System(Property::Any<Godot::Node> node) : base
	(
		new Property::Function.Result.Actual<System::Double>(
			() => node.Value.GetProcessDeltaTime())
	)
	{
	}
}