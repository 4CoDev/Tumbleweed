using Godot;
using Tumbleweed.Numbers.Real;
using Tumbleweed.Numbers.Real.FromSystem;
using Tumbleweed.Scalars;

namespace DotGod.Time.FromGodot;

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