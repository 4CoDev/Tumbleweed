using Godot;
using Tumbleweed.Scalar;

namespace DotGod.Time.ToSystem;

public sealed class FrameTime : ScalarEnvelope<Double>
{
	public FrameTime(Node node) : this
	(
		new ScalarValue<Node>(node)
	)
	{
	}
	
	public FrameTime(IScalar<Node> node) : base
	(
		new ResultOfFunction<Double>(
			() => node.Value.GetProcessDeltaTime())
	)
	{
	}
}