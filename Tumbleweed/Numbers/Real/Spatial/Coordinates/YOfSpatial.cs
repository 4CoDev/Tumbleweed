using Tumbleweed.Points.Spatial;
using Tumbleweed.Points.Spatial.Coordinates;

namespace Tumbleweed.Numbers.Real.Spatial.Coordinates;

public sealed class YOfSpatial : RealEnvelope
{
	public YOfSpatial(IPoint<IReal> point) : base
	(
		new RealOfScalar(
			new YOfPoint<IReal>(point))
	)
	{
	}
}