using Tumbleweed._Enumerable;
using Tumbleweed.Number.Real;
using Tumbleweed.Spatial.Point;

namespace DotGod.Spatial._Node.Batch.Spaces.Points;

public sealed class BothPointsOfSpace :
	EnumerableEnvelope<IPoint<IReal>>
{
	public BothPointsOfSpace(ISpace occupation) : base
	(
		new EnumerableWithElements<IPoint<IReal>>(
			new FromPointOfSpace(occupation),
			new ToPointOfSpace(occupation))
	)
	{
	}
}