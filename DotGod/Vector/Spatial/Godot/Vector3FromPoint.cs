using Godot;
using Tumbleweed.Number.Real;
using Tumbleweed.Number.Real.Binary.ToSystem.Singles;
using Tumbleweed.Point.Spatial;
using Tumbleweed.Scalar;

namespace DotGod.Vector.Spatial.Godot;

public sealed class Vector3FromPoint : ScalarEnvelope<Vector3>
{
	public Vector3FromPoint(IPoint<IReal> point) : base
	(
		new ResultOfFunction<Vector3>(
			() => Result(point))
	)
	{
	}

	private static Vector3 Result(IPoint<IReal> point)
	{
		return new Vector3(
			new SingleFromReal(point.X).Value,
			new SingleFromReal(point.Y).Value,
			new SingleFromReal(point.Z).Value);
	}
}