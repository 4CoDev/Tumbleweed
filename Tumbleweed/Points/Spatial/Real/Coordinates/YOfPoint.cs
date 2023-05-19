using Tumbleweed.Numbers.Real;
using Tumbleweed.Points.Spatial.Coordinates;

namespace Tumbleweed.Points.Spatial.Real.Coordinates;

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