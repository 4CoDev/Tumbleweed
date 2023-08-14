using Real = Tumbleweed.Number.Real;
using Godot = Godot;
using Immutable = Tumbleweed.Scalar.Immutable;
using Time = DotGod.Node.Time;

namespace DotGod.Node.Time.Physic;

public sealed class Tumbleweed : Real::Envelope
{
	public Tumbleweed(Godot::Node node) : this
	(
		new Immutable::With.Value<Godot::Node>(node)
	)
	{
	}
	
	public Tumbleweed(Immutable::Any<Godot::Node> node) : base
	(
		new Real::Binary.Precision.Double.From.System.One(
			new Time::Physic.System(node))
	)
	{
	}
}