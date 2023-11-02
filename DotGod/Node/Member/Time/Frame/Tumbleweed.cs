using Tumbleweed.Mathematics.Number.Real;
using Tumbleweed.Mathematics.Number.Real.Binary.Precision.Double.From.System;
using Godot = Godot;
using Property = Tumbleweed.Property.Output;

namespace DotGod.Node.Member.Time.Frame;

public sealed class Tumbleweed : Envelope
{
	public Tumbleweed(Godot::Node node) : this
	(
		new Property::With.Value.One<Godot::Node>(node)
	)
	{
	}
	
	public Tumbleweed(Property::Any<Godot::Node> node) : base
	(
		new One(
			new System(node))
	)
	{
	}
}