using Godot;
using Tumbleweed.Numbers.Real;
using Tumbleweed.Numbers.Real.FromSystem;
using Tumbleweed.Scalars;

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