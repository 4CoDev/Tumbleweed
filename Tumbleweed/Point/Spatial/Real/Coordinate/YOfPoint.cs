using Tumbleweed.Number.Real;
using Tumbleweed.Point.Spatial.Coordinate;

namespace Tumbleweed.Point.Spatial.Real.Coordinate;

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