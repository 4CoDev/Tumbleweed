using Aabb = Tumbleweed.Mathematics.Geometry.Stereometry.Shape.Parametric.Aabb;

namespace DotGod.Node.Batch.Dimension.Spatial.Measurement.Measured.Subbatch.NonNullable.Collided.By.Aabb.Point.A;

public sealed class One : Envelope
{
	public One
	(
		Any batch,
		Aabb::Any space
	) : base
	(
		new By.Point.One(
			batch,
			new Aabb::Point.A.Actual(space))
	)
	{
	}
}