using Tumbleweed.Number.Real;
using Tumbleweed.Point.Spatial.Coordinate;

namespace Tumbleweed.Point.Spatial.Real.Coordinate;

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