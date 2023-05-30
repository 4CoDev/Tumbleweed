using DotGod._Node.BatchMap.Spatial.Spaces.Points;
using Tumbleweed.Number.Real;
using Tumbleweed.Spatial.Point;
using Tumbleweed.Spatial.Point.Real.Arithmetic;

namespace DotGod._Node.BatchMap.Spatial.Spaces;

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