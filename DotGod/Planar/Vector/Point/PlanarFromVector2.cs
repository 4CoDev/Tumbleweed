using Godot;
using Tumbleweed.Number.Real;
using Tumbleweed.Number.Real.FromSystem;
using Tumbleweed.Planar.Point;
using Tumbleweed.Scalar;

namespace DotGod.Planar.Vector.Point;

public sealed class PointFromVector2 : PointEnvelope<IReal>
{
	public PointFromVector2(Vector2 vector) : this
	(
		new ScalarValue<Vector2>(vector)
	)
	{
	}

	public PointFromVector2(IScalar<Vector2> vector) : base
	(
		new PointWithCoordinates<IReal>(
			new RealFromSingle(vector.Value.X),
			new RealFromSingle(vector.Value.Y))
	)
	{
	}
}