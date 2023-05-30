using DotGod._Node.BatchMap.Spatial.Spaces.Points;
using Tumbleweed.Number.Real;
using Tumbleweed.Spatial.Point;
using Tumbleweed.Spatial.Point.Real.Arithmetic.Distance;

namespace DotGod._Node.BatchMap.Spatial.Spaces;

public sealed class SizeOfSpace : PointEnvelope<IReal>
{
	public SizeOfSpace(ISpace space) : base
	(
		new L1BetweenPoints(
			new FromPointOfSpace(space),
			new ToPointOfSpace(space))
	)
	{
	}
}