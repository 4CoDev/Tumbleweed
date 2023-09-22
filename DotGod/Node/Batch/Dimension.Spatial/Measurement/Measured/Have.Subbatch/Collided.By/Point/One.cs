using Tumbleweed.Point.Spatial;
using Tumbleweed.Point.Spatial.Generic;

namespace DotGod.Node.Batch.Dimension.Spatial.Measurement.Measured.Have.Subbatch.Collided.By.Point;

public sealed class One : Tumbleweed.Boolean.Envelope
{
	public One
	(
		Measured.Any batch,
		Any<Tumbleweed.Number.Real.Any> point
	) : base
	(
		new Unmeasured.Have.Subbatch.At.Index.One(
			batch,
			new Tumbleweed.Geometry.Stereometry.Shape.Parametric.Aabb.Octant.Collided.By.Point.Index.One(
				new Measured.Member.Aabb.One(batch),
				point))
	)
	{
	}
}