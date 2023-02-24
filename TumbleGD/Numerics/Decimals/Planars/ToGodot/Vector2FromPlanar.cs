using Godot;
using Tumbleweed.Numerics.Binaries.ToSystem.Singles;
using Tumbleweed.Numerics.Decimals;
using Tumbleweed.Numerics.Planar;
using Tumbleweed.Scalars;

namespace TumbleGD.Numerics.Decimals.Planars.ToGodot;

public sealed class Vector2FromPlanar : ScalarEnvelope<Vector2>
{
	public Vector2FromPlanar(IPlanar<IDecimal> planar) : base
	(
		new ScalarOfDelegate<Vector2>(() => Result(planar))
	)
	{
	}

	private static Vector2 Result(IPlanar<IDecimal> planar)
	{
		return new Vector2(
			new SingleFromDecimal(planar.X).Value,
			new SingleFromDecimal(planar.Y).Value);
	}
}