using Tumbleweed.Numbers.Real.Arithmetics.Rounding;
using Tumbleweed.Numbers.Real.Spatial.Coordinates;
using Tumbleweed.Points.Spatial;

namespace Tumbleweed.Numbers.Real.Spatial.Arithmetics.Rounding;

public sealed class NearestIntegerOfPoint : PointEnvelope<IReal>
{
	public NearestIntegerOfPoint(IPoint<IReal> point) : base
	(
		new PointWithCoordinates(
			new NearestIntegerOfReal(new XOfSpatial(point)),
			new NearestIntegerOfReal(new YOfSpatial(point)),
			new NearestIntegerOfReal(new ZOfSpatial(point)))
	)
	{
	}
}