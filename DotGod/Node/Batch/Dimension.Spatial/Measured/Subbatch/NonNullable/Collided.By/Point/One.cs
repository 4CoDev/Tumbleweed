using Tumbleweed.Point.Spatial;

namespace DotGod.Node.Batch.Dimension.Spatial.Measured.Subbatch.NonNullable.Collided.By.Point;

public sealed class One : Envelope
{
	public One
	(
		Any batch,
		Any<Tumbleweed.Number.Real.Any> point
	) : base
	(
		new At.Index.One(
			batch,
			new Tumbleweed.Geometry.Spatial.Aabb.Octant.Collided.By.Point.Index.One(
				new Member.Aabb.One(batch),
				point))
	)
	{
	}
}