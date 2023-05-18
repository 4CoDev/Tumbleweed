using Tumbleweed.Points.Spatial;
using Tumbleweed.Points.Spatial.Coordinates;

namespace Tumbleweed.Numbers.Real.Spatial.Coordinates;

public sealed class XOfSpatial : RealEnvelope
{
	public XOfSpatial(IPoint<IReal> point) : base
	(
		new RealOfScalar(
			new XOfPoint<IReal>(point))
	)
	{
	}
}