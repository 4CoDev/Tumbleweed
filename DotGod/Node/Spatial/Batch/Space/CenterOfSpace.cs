using DotGod.Node.Spatial.Batch.Space.Points;
using Tumbleweed.Point.Spatial;
using Tumbleweed.Point.Spatial.Real.Arithmetic;

namespace DotGod.Node.Spatial.Batch.Space;

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