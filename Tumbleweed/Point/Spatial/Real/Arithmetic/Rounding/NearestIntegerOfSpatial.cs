using Tumbleweed.Number.Real;
using Tumbleweed.Number.Real.Arithmetic.Rounding;
using Tumbleweed.Point.Spatial.Real.Coordinate;
using Tumbleweed.Point.Spatial.Real.With.Coordinates;
using Tumbleweed.Point.Spatial.Real.With.Coordinates.Directly;

namespace Tumbleweed.Point.Spatial.Real.Arithmetic.Rounding;

public sealed class NearestIntegerOfPoint : Envelope<Any>
{
	public NearestIntegerOfPoint(Any<Any> point) : base
	(
		new Unique(
			new NearestIntegerOfReal(new XOfPoint(point)),
			new NearestIntegerOfReal(new YOfPoint(point)),
			new NearestIntegerOfReal(new ZOfPoint(point)))
	)
	{
	}
}