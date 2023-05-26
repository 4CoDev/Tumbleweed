using Godot;
using Tumbleweed.Number.Real;
using Tumbleweed.Number.Real.FromSystem;
using Tumbleweed.Point.Spatial;
using Tumbleweed.Scalar;

namespace DotGod.Vector.Spatial.Point;

public sealed class PointFromVector3 : PointEnvelope<IReal>
{
	public PointFromVector3(Vector3 vector) : this
	(
		new ScalarValue<Vector3>(vector)
	)
	{
	}

	public PointFromVector3(IScalar<Vector3> vector) : base
	(
		new PointWithCoordinates<IReal>(
			new RealFromSingle(vector.Value.X),
			new RealFromSingle(vector.Value.Y),
			new RealFromSingle(vector.Value.Z))
	)
	{
	}
}