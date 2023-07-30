using Godot;
using Tumbleweed.Scalar;
using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.Function.Result;
using Tumbleweed.Scalar.Immutable.Of;
using Tumbleweed.Scalar.Immutable.With;

namespace DotGod.Time.ToSystem;

public sealed class FrameTime : Envelope<Double>
{
	public FrameTime(Node node) : this
	(
		new Value<Node>(node)
	)
	{
	}
	
	public FrameTime(Any<Node> node) : base
	(
		new Actual<Double>(
			() => node.Value.GetProcessDeltaTime())
	)
	{
	}
}