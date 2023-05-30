using Tumbleweed.Number.Real;
using Tumbleweed.Spatial.Point.Coordinate;

namespace Tumbleweed.Spatial.Point.Real.Coordinate;

public sealed class YOfPoint : RealEnvelope
{
	public YOfPoint(IPoint<IReal> point) : base
	(
		new RealOfScalar(
			new YOfPoint<IReal>(point))
	)
	{
	}
}