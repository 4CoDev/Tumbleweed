using Godot;
using Tumbleweed.Number.Real;
using Tumbleweed.Number.Real.Binary.ToSystem.Singles;
using Tumbleweed.Planar.Point;
using Tumbleweed.Scalar;

namespace DotGod.Planar.Vector;

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