using Tumbleweed.Numbers.Real;
using Tumbleweed.Points.Spatial.Coordinates;

namespace Tumbleweed.Points.Spatial.Real.Coordinates;

public sealed class XOfPoint : RealEnvelope
{
	public XOfPoint(IPoint<IReal> point) : base
	(
		new RealOfScalar(
			new XOfPoint<IReal>(point))
	)
	{
	}
}