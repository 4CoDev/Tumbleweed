using Godot;
using Tumbleweed.Scalars;

namespace DotGod.Time.FromGodot.ToSystem;

public sealed class PhysicsTime : ScalarEnvelope<Double>
{
	public PhysicsTime(Node node) : this
	(
		new ScalarValue<Node>(node)
	)
	{
	}
	
	public PhysicsTime(IScalar<Node> node) : base
	(
		new ValueOfFunction<Double>(
			() => node.Value.GetPhysicsProcessDeltaTime())
	)
	{
	}
}