using Tumbleweed.Point.Spatial;

namespace DotGod.Node.Batch.Dimension.Spatial.Measured.Have.Subbatch.Collided.By.Point;

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
			new Tumbleweed.Geometry.Spatial.Aabb.Octant.Collided.By.Point.Index.One(
				new Measured.Member.Aabb.One(batch),
				point))
	)
	{
	}
}