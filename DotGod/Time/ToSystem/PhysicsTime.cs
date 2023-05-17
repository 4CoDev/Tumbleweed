using Godot;
using Tumbleweed.Scalars;

namespace DotGod.Time.ToSystem;

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
		new ResultOfFunction<Double>(
			() => node.Value.GetPhysicsProcessDeltaTime())
	)
	{
	}
}