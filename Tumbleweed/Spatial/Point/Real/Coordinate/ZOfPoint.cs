using Tumbleweed.Number.Real;
using Tumbleweed.Spatial.Point.Coordinate;

namespace Tumbleweed.Spatial.Point.Real.Coordinate;

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