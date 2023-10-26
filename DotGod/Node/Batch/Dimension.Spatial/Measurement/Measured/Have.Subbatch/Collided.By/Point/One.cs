using Godot;
using Boolean = Tumbleweed.Mathematics.Boolean;
using Vector = Tumbleweed.Mathematics.Vector.Spatial;
using Number = Tumbleweed.Mathematics.Number;
using Aabb = Tumbleweed.Mathematics.Geometry.Stereometry.Shape.Parametric.Aabb;

namespace DotGod.Node.Batch.Dimension.Spatial.Measurement.Measured.Have.Subbatch.Collided.By.Point;

public sealed class One : Boolean::Envelope
{
	public One
	(
		Measured.Any batch,
		Vector::Generic.Any<Number::Real.Any> point
	) : base
	(
		new Unmeasured.Have.Subbatch.At.Index.One(
			batch,
			new Aabb::Octant.Collided.By.Point.Index.One(
				new Measured.Member.Aabb.One(batch),
				point))
	)
	{
	}
}