using Godot;
using Tumbleweed.Numbers.Real;
using Tumbleweed.Numbers.Real.FromSystem;
using Tumbleweed.Points.Planar;
using Tumbleweed.Scalars;

namespace DotGod.Vectors.Planar.Points;

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