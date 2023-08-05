using Immutable = Tumbleweed.Scalar.Immutable;
using System = System;
using Godot = Godot;

namespace DotGod.Node.Time.Frame;

public sealed class System : Immutable::Envelope<System::Double>
{
	public System(Godot::Node node) : this
	(
		new Immutable::With.Value<Godot::Node>(node)
	)
	{
	}
	
	public System(Immutable::Any<Godot::Node> node) : base
	(
		new Immutable::Function.Result.Actual<System::Double>(
			() => node.Value.GetProcessDeltaTime())
	)
	{
	}
}