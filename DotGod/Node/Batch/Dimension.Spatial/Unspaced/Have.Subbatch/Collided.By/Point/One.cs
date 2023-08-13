using DotGod.Node.Batch.Dimension.Spatial.Spaced;
using Tumbleweed.Point.Spatial;

namespace DotGod.Node.Batch.Dimension.Spatial.Unspaced.Have.Subbatch.Collided.By.Point;

public sealed class One : Tumbleweed.Boolean.Envelope
{
	public One
	(
		Spaced.Any batch,
		Any<Tumbleweed.Number.Real.Any> point
	) : base
	(
		new At.Index.One(
			batch,
			new Spatial.Space.Octant.Collided.By.Point.Index.One(batch, point))
	)
	{
	}
}