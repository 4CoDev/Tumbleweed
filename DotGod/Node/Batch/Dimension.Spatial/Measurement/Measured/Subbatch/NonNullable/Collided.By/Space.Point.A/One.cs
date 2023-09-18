using Actual = Tumbleweed.Geometry.Spatial.Shape.Parametric.Aabb.Point.A.Actual;

namespace DotGod.Node.Batch.Dimension.Spatial.Measurement.Measured.Subbatch.NonNullable.Collided.By.Space.Point.A;

public sealed class One : Envelope
{
	public One(Any batch, Tumbleweed.Geometry.Spatial.Shape.Parametric.Aabb.Any space) : base
	(
		new By.Point.One(
			batch,
			new Actual(space))
	)
	{
	}
}