using Godot;
using Tumbleweed.Number.Real;
using Tumbleweed.Number.Real.FromSystem;
using Tumbleweed.Scalar;

namespace DotGod.Time;

public sealed class PhysicsTime : RealEnvelope
{
	public PhysicsTime(Node node) : this
	(
		new ScalarValue<Node>(node)
	)
	{
	}
	
	public PhysicsTime(IScalar<Node> node) : base
	(
		new RealFromDouble(
			new ToSystem.PhysicsTime(node))
	)
	{
	}
}