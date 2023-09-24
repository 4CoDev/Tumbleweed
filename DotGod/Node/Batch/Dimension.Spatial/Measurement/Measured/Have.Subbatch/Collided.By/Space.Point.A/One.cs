using Actual = Tumbleweed.Geometry.Stereometry.Shape.Parametric.Aabb.Point.A.Actual;

namespace DotGod.Node.Batch.Dimension.Spatial.Measurement.Measured.Have.Subbatch.Collided.By.Space.Point.A;

public sealed class One : Tumbleweed.Mathematics.Boolean.Envelope
{
	public One
	(
		Measured.Any batch,
		Tumbleweed.Geometry.Stereometry.Shape.Parametric.Aabb.Any space
	) : base
	(
		new Collided.By.Point.One(
			batch,
			new Actual(space))
	)
	{
	}
}