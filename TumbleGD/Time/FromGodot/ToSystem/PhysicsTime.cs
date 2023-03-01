using Godot;
using Tumbleweed.Scalars;

namespace TumbleGD.Time.FromGodot.ToSystem;

public sealed class PhysicsTime : ScalarEnvelope<double>
{
	public PhysicsTime() : base
	(
		new ValueOfDelegate<double>(
			() => 1.0 / Engine.PhysicsTicksPerSecond)
	)
	{
	}
}