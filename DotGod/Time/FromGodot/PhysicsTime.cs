using Godot;
using Tumbleweed.Numerics.Fractional;
using Tumbleweed.Numerics.Fractional.FromSystem;
using Tumbleweed.Scalars;

namespace DotGod.Time.FromGodot;

public sealed class PhysicsTime : FractionalEnvelope
{
	public PhysicsTime(Node node) : this
	(
		new ScalarValue<Node>(node)
	)
	{
	}
	
	public PhysicsTime(IScalar<Node> node) : base
	(
		new FractionalFromDouble(
			new ToSystem.PhysicsTime(node))
	)
	{
	}
}