using Godot;
using Tumbleweed.Number.Real;
using Tumbleweed.Number.Real.Binary.Precision.Double.From.System;
using Tumbleweed.Scalar;
using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.Of;
using Tumbleweed.Scalar.Immutable.With;

namespace DotGod.Time;

public sealed class PhysicsTime : Envelope
{
	public PhysicsTime(Node node) : this
	(
		new Value<Node>(node)
	)
	{
	}
	
	public PhysicsTime(Any<Node> node) : base
	(
		new One(
			new ToSystem.PhysicsTime(node))
	)
	{
	}
}