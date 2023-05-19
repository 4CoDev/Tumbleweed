using Tumbleweed.Numbers.Real;
using Tumbleweed.Points.Spatial.Coordinates;

namespace Tumbleweed.Points.Spatial.Real.Coordinates;

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