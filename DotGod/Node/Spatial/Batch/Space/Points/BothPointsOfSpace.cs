using Tumbleweed.Point.Spatial;
using Enumerable = Tumbleweed.Enumerable;

namespace DotGod.Node.Spatial.Batch.Space.Points;

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