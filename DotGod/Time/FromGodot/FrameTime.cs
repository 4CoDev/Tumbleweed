using Godot;
using Tumbleweed.Numerics.Fractional;
using Tumbleweed.Numerics.Fractional.FromSystem;
using Tumbleweed.Scalars;

namespace DotGod.Time.FromGodot;

public sealed class FrameTime : FractionalEnvelope
{
	public FrameTime(Node node) : this
	(
		new ScalarValue<Node>(node)
	)
	{
	}
	
	public FrameTime(IScalar<Node> node) : base
	(
		new FractionalFromDouble(
			new ToSystem.FrameTime(node))
	)
	{
	}
}