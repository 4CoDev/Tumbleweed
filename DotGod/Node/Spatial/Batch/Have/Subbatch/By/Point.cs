using DotGod.Node.Spatial.Batch.Space.Octants;
using DotGod.Node.Spatial.Spaced.Abstract;
using Tumbleweed.Point.Spatial;

namespace DotGod.Node.Spatial.Batch.Have.Subbatch.By;

public sealed class Point : Tumbleweed.Boolean.Envelope
{
	public Point
	(
		IBatch batch,
		Any<Tumbleweed.Number.Real.Any> point
	) : base
	(
		new By.Index(
			batch,
			new OctantIndexWithPoint(batch, point))
	)
	{
	}
}