using DotGod.Spatial._Node.Batch.Space.Octants;
using Tumbleweed.Number.Real;
using Tumbleweed.Point.Spatial;

namespace DotGod.Spatial._Node.Spaced.Batch.Subbatch.By;

public sealed class Point : Envelope
{
	public Point
	(
		Abstract.IBatch batch,
		Any<Any> point
	) : base
	(
		new Index(
			batch,
			new OctantIndexWithPoint(batch, point))
	)
	{
	}
}