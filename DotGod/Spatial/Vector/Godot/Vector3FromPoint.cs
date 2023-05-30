using Godot;
using Tumbleweed.Number.Real;
using Tumbleweed.Number.Real.Binary.ToSystem.Singles;
using Tumbleweed.Scalar;
using Tumbleweed.Spatial.Point;

namespace DotGod.Spatial.Vector.Godot;

public sealed class Vector3FromPoint : ScalarEnvelope<Vector3>
{
	public Vector3FromPoint(IPoint<IReal> point) : base
	(
		new ResultOfFunction<Vector3>(
			() => Result(point))
	)
	{
	}

	private static Vector3 Result(IPoint<IReal> point) =>
	(
		new Vector3(
			new SingleFromReal(point.X).Value,
			new SingleFromReal(point.Y).Value,
			new SingleFromReal(point.Z).Value)
	);
}