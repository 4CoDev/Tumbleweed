using Godot;
using Tumbleweed.Numbers.Real;
using Tumbleweed.Numbers.Real.Binaries.ToSystem.Singles;
using Tumbleweed.Points.Planar;
using Tumbleweed.Scalars;

namespace DotGod.Vectors.Planar.Godot;

public sealed class Vector2FromPlanar : ScalarEnvelope<Vector2>
{
	public Vector2FromPlanar(IPoint<IReal> point) : base
	(
		new ResultOfFunction<Vector2>(
			() => Result(point))
	)
	{
	}

	private static Vector2 Result(IPoint<IReal> point)
	{
		return new Vector2(
			new SingleFromReal(point.X).Value,
			new SingleFromReal(point.Y).Value);
	}
}