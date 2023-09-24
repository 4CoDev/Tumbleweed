using Actual = Tumbleweed.Mathematics.Geometry.Stereometry.Shape.Parametric.Aabb.Point.A.Actual;

namespace DotGod.Node.Batch.Dimension.Spatial.Measurement.Measured.Subbatch.NonNullable.Collided.By.Space.Point.A;

public sealed class One : Envelope
{
	public One(Any batch, Tumbleweed.Mathematics.Geometry.Stereometry.Shape.Parametric.Aabb.Any space) : base
	(
		new By.Point.One(
			batch,
			new Actual(space))
	)
	{
	}
}