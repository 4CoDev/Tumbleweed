using Godot;
using Tumbleweed.Scalars;

namespace TumbleGD.Time.FromGodot.ToSystem;

public sealed class FrameTime : ScalarEnvelope<double>
{
	public FrameTime() : base
	(
		new ValueOfDelegate<double>(
			() => 1.0 / Engine.GetFramesPerSecond())
	)
	{
	}
}