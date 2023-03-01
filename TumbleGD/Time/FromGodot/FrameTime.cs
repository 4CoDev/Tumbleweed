using Tumbleweed.Numerics.Fractional;
using Tumbleweed.Numerics.Fractional.FromSystem;

namespace TumbleGD.Time.FromGodot;

public sealed class FrameTime : FractionalEnvelope
{
	public FrameTime() : base
	(
		new FractionalFromDouble(
			new ToSystem.FrameTime())
	)
	{
	}
}