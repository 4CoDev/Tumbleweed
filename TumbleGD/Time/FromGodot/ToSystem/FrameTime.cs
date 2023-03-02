using Godot;
using Tumbleweed.Scalars;

namespace TumbleGD.Time.FromGodot.ToSystem;

public sealed class FrameTime : ScalarEnvelope<double>
{
	public FrameTime(Node node) : this
	(
		new ScalarOfValue<Node>(node)
	)
	{
	}
	
	public FrameTime(IScalar<Node> node) : base
	(
		new ValueOfDelegate<double>(
			() => node.Value.GetProcessDeltaTime())
	)
	{
	}
}