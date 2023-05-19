using Tumbleweed.Numbers.Real;
using Tumbleweed.Numbers.Real.Arithmetics.Rounding;
using Tumbleweed.Points.Spatial.Real.Coordinates;

namespace Tumbleweed.Points.Spatial.Real.Arithmetics.Rounding;

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