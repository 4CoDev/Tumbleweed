using Godot;
using Tumbleweed.Scalar;
using Tumbleweed.Scalar.Function;

namespace DotGod.Time.ToSystem;

public sealed class FrameTime : Envelope<Double>
{
	public FrameTime(Node node) : this
	(
		new Tumbleweed.Scalar.Of.Value<Node>(node)
	)
	{
	}
	
	public FrameTime(Any<Node> node) : base
	(
		new Tumbleweed.Scalar.Function.Result<Double>(
			() => node.Value.GetProcessDeltaTime())
	)
	{
	}
}