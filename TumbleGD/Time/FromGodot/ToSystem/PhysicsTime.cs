using Godot;
using Tumbleweed.Scalars;

namespace TumbleGD.Time.FromGodot.ToSystem;

public sealed class PhysicsTime : ScalarEnvelope<double>
{
	public PhysicsTime(Node node) : this
	(
		new ScalarOfValue<Node>(node)
	)
	{
	}
	
	public PhysicsTime(IScalar<Node> node) : base
	(
		new ValueOfDelegate<double>(
			() => node.Value.GetPhysicsProcessDeltaTime())
	)
	{
	}
}