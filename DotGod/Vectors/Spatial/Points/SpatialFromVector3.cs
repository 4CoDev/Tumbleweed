using Godot;
using Tumbleweed.Numbers.Real;
using Tumbleweed.Numbers.Real.FromSystem;
using Tumbleweed.Points.Spatial;
using Tumbleweed.Scalars;

namespace DotGod.Vectors.Spatial.Points;

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