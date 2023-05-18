using Tumbleweed.Points.Spatial;
using Tumbleweed.Points.Spatial.Coordinates;

namespace Tumbleweed.Numbers.Real.Spatial.Coordinates;

public sealed class ZOfSpatial : RealEnvelope
{
	public ZOfSpatial(IPoint<IReal> point) : base
	(
		new RealOfScalar(
			new ZOfPoint<IReal>(point))
	)
	{
	}
}