using Tumbleweed.Mathematics.Number.Real;
using Tumbleweed.Mathematics.Number.Real.Binary.Precision.Double.From.System;
using Godot = Godot;
using Immutable = Tumbleweed.Scalar.Immutable;

namespace DotGod.Node.Member.Time.Frame;

public sealed class Tumbleweed : Envelope
{
	public Tumbleweed(Godot::Node node) : this
	(
		new Immutable::With.Value<Godot::Node>(node)
	)
	{
	}
	
	public Tumbleweed(Immutable::Any<Godot::Node> node) : base
	(
		new One(
			new System(node))
	)
	{
	}
}