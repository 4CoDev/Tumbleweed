using Aabb = Tumbleweed.Mathematics.Geometry.Stereometry.Shape.Parametric.Aabb;

namespace DotGod.Node.Batch.Dimension.Spatial.Measurement.Measured.Have.Subbatch.Collided.By.Space.Point.A;

public sealed class One : Tumbleweed.Mathematics.Boolean.Envelope
{
	public One
	(
		Measured.Any batch,
		Aabb::Any aabb
	) : base
	(
		new Collided.By.Point.One(
			batch,
			new Aabb::Point.A.Actual(aabb))
	)
	{
	}
}