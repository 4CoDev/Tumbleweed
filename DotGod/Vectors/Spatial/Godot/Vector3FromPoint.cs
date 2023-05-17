using Godot;
using Tumbleweed.Numbers.Real;
using Tumbleweed.Numbers.Real.Binaries.ToSystem.Singles;
using Tumbleweed.Points.Spatial;
using Tumbleweed.Scalars;

namespace DotGod.Vectors.Spatial.Godot;

public sealed class Vector3FromPoint : ScalarEnvelope<Vector3>
{
	public Vector3FromPoint(ISpatial<IReal> point) : base
	(
		new ResultOfFunction<Vector3>(
			() => Result(point))
	)
	{
	}

	private static Vector3 Result(ISpatial<IReal> point)
	{
		return new Vector3(
			new SingleFromReal(point.X).Value,
			new SingleFromReal(point.Y).Value,
			new SingleFromReal(point.Z).Value);
	}
}