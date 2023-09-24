using Tumbleweed.Mathematics.Number.Real;
using Tumbleweed.Mathematics.Number.Real.Binary.Precision.Double.From.System;
using Real = Tumbleweed.Mathematics.Number.Real;
using Godot = Godot;
using Immutable = Tumbleweed.Scalar.Immutable;
using Time = DotGod.Node.Time;

namespace DotGod.Node.Time.Physic;

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
			new Time::Physic.System(node))
	)
	{
	}
}