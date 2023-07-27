using DotGod.Spatial._Node.Batch.Space.Octants;
using Tumbleweed.Boolean;
using Tumbleweed.Number.Real;
using Tumbleweed.Point.Spatial;

namespace DotGod.Spatial._Node.Batch.Have.Subbatch.By;

public sealed class Point : Tumbleweed.Boolean.Envelope
{
	public Point
	(
		Spaced.Abstract.IBatch batch,
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