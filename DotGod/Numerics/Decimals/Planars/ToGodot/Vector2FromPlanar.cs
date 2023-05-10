using Godot;
using Tumbleweed.Numbers.Planar;
using Tumbleweed.Numbers.Real;
using Tumbleweed.Numbers.Real.Binaries.ToSystem.Singles;
using Tumbleweed.Scalars;

namespace DotGod.Numerics.Decimals.Planars.ToGodot;

public sealed class Vector2FromPlanar : ScalarEnvelope<Vector2>
{
	public Vector2FromPlanar(IPlanar<IReal> planar) : base
	(
		new ResultOfFunction<Vector2>(() => Result(planar))
	)
	{
	}

	private static Vector2 Result(IPlanar<IReal> planar)
	{
		return new Vector2(
			new SingleFromReal(planar.X).Value,
			new SingleFromReal(planar.Y).Value);
	}
}