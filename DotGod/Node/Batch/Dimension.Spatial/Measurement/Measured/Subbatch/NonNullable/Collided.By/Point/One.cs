using Batch = DotGod.Node.Batch.Dimension.Spatial.Measurement.Measured;
using Vector = Tumbleweed.Mathematics.Vector.Spatial;
using Number = Tumbleweed.Mathematics.Number;
using Aabb = Tumbleweed.Mathematics.Geometry.Stereometry.Shape.Parametric.Aabb;

namespace DotGod.Node.Batch.Dimension.Spatial.Measurement.Measured.Subbatch.NonNullable.Collided.By.Point;

public sealed class One : Envelope
{
	public One
	(
		Batch::Any batch,
		Vector::Generic.Any<Number::Real.Any> point
	) : base
	(
		new At.Index.One(
			batch,
			new Aabb::Octant.Collided.By.Point.Index.One(
				new Member.Aabb.One(batch),
				point))
	)
	{
	}
}