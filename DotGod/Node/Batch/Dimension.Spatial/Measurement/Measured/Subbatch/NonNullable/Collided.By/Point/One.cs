using Tumbleweed.Mathematics.Geometry.Stereometry.Point.Generic;


namespace DotGod.Node.Batch.Dimension.Spatial.Measurement.Measured.Subbatch.NonNullable.Collided.By.Point;

public sealed class One : Envelope
{
	public One
	(
		Any batch,
		Any<Tumbleweed.Mathematics.Number.Real.Any> point
	) : base
	(
		new At.Index.One(
			batch,
			new Tumbleweed.Mathematics.Geometry.Stereometry.Shape.Parametric.Aabb.Octant.Collided.By.Point.Index.One(
				new Member.Aabb.One(batch),
				point))
	)
	{
	}
}