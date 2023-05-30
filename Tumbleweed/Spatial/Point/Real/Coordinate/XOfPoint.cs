using Tumbleweed.Number.Real;
using Tumbleweed.Spatial.Point.Coordinate;

namespace Tumbleweed.Spatial.Point.Real.Coordinate;

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