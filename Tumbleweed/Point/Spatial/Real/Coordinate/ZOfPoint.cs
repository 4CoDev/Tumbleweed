using Tumbleweed.Number.Real;
using Tumbleweed.Point.Spatial.Coordinate;

namespace Tumbleweed.Point.Spatial.Real.Coordinate;

public sealed class ZOfPoint : RealEnvelope
{
	public ZOfPoint(IPoint<IReal> point) : base
	(
		new RealOfScalar(
			new ZOfPoint<IReal>(point))
	)
	{
	}
}