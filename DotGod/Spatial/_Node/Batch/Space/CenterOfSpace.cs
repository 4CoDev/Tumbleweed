using DotGod.Spatial._Node.Batch.Space.Points;
using Tumbleweed.Number.Real;
using Tumbleweed.Point.Spatial;
using Tumbleweed.Point.Spatial.Real.Arithmetic;

namespace DotGod.Spatial._Node.Batch.Space;

public sealed class CenterOfSpace : Envelope<Tumbleweed.Number.Real.Any>
{
	public CenterOfSpace(ISpace space) : base
	(
		new QuotientByReal(
			new SumOfPoints(
				new ToPointOfSpace(space),
				new FromPointOfSpace(space)),
			2)
	)
	{
	}
}