using Godot;
using Tumbleweed.Scalar;
using Tumbleweed.Scalar.Function;

namespace DotGod.Time.ToSystem;

public sealed class PhysicsTime : Envelope<Double>
{
	public PhysicsTime(Node node) : this
	(
		new Tumbleweed.Scalar.Of.Value<Node>(node)
	)
	{
	}
	
	public PhysicsTime(Any<Node> node) : base
	(
		new Tumbleweed.Scalar.Function.Result<Double>(
			() => node.Value.GetPhysicsProcessDeltaTime())
	)
	{
	}
}