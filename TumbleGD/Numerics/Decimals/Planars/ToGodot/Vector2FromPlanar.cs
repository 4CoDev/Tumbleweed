using Godot;
using Tumbleweed.Numerics.Fractional;
using Tumbleweed.Numerics.Fractional.Binaries.ToSystem.Singles;
using Tumbleweed.Numerics.Planar;
using Tumbleweed.Scalars;

namespace TumbleGD.Numerics.Decimals.Planars.ToGodot;

public sealed class Vector2FromPlanar : ScalarEnvelope<Vector2>
{
	public Vector2FromPlanar(IPlanar<IFractional> planar) : base
	(
		new ValueOfFunction<Vector2>(() => Result(planar))
	)
	{
	}

	private static Vector2 Result(IPlanar<IFractional> planar)
	{
		return new Vector2(
			new SingleFromFractional(planar.X).Value,
			new SingleFromFractional(planar.Y).Value);
	}
}