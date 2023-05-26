using Tumbleweed.Number.Real;
using Tumbleweed.Number.Real.Arithmetic.Rounding;
using Tumbleweed.Point.Spatial.Real.Coordinate;

namespace Tumbleweed.Point.Spatial.Real.Arithmetic.Rounding;

public sealed class NearestIntegerOfPoint : PointEnvelope<IReal>
{
	public NearestIntegerOfPoint(IPoint<IReal> point) : base
	(
		new PointWithCoordinates(
			new NearestIntegerOfReal(new XOfPoint(point)),
			new NearestIntegerOfReal(new YOfPoint(point)),
			new NearestIntegerOfReal(new ZOfPoint(point)))
	)
	{
	}
}