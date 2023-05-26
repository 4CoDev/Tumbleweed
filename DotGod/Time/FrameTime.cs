using Godot;
using Tumbleweed.Number.Real;
using Tumbleweed.Number.Real.FromSystem;
using Tumbleweed.Scalar;

namespace DotGod.Time;

public sealed class FrameTime : RealEnvelope
{
	public FrameTime(Node node) : this
	(
		new ScalarValue<Node>(node)
	)
	{
	}
	
	public FrameTime(IScalar<Node> node) : base
	(
		new RealFromDouble(
			new ToSystem.FrameTime(node))
	)
	{
	}
}