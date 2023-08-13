using Tumbleweed.Point.Spatial;

namespace DotGod.Node.Batch.Dimension.Spatial.Spaced.Subbatch.NonNullable.Collided.By.Point;

public sealed class One : Envelope
{
	public One
	(
		Any batch,
		Any<Tumbleweed.Number.Real.Any> point
	) : base
	(
		new Node.Batch.Dimension.Spatial.Spaced.Subbatch.NonNullable.At.Index.One(
			batch,
			new Spatial.Space.Octant.Collided.By.Point.Index.One(batch, point))
	)
	{
	}
}