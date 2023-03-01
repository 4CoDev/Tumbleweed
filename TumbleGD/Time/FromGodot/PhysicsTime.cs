using Tumbleweed.Numerics.Fractional;
using Tumbleweed.Numerics.Fractional.FromSystem;

namespace TumbleGD.Time.FromGodot;

public sealed class PhysicsTime : FractionalEnvelope
{
	public PhysicsTime() : base
	(
		new FractionalFromDouble(
			new ToSystem.PhysicsTime())
	)
	{
	}
}