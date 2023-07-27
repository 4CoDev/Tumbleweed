using Tumbleweed.Enumerable;
using Tumbleweed.Number.Real;
using Tumbleweed.Point.Spatial;
using Enumerable = Tumbleweed.Enumerable;

namespace DotGod.Spatial._Node.Batch.Space.Points;

public sealed class BothPointsOfSpace : Enumerable.Envelope<Any<Tumbleweed.Number.Real.Any>>
{
	public BothPointsOfSpace(ISpace occupation) : base
	(
		new Enumerable::From.Array<Any<Tumbleweed.Number.Real.Any>>(
			new FromPointOfSpace(occupation),
			new ToPointOfSpace(occupation))
	)
	{
	}
}