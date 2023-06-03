using DotGod.Spatial._Node.Batch.Space.Points;
using Tumbleweed.Number.Real;
using Tumbleweed.Spatial.Point;
using Tumbleweed.Spatial.Point.Real.Arithmetic;

namespace DotGod.Spatial._Node.Batch.Space;

public sealed class CenterOfSpace : PointEnvelope<IReal>
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