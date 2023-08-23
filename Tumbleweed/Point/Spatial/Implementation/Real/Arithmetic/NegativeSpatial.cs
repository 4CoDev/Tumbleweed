using Tumbleweed.Number.Real;
using Tumbleweed.Number.Real.Arithmetic;
using Tumbleweed.Point.Spatial.Implementation.Real.Coordinate;
using Tumbleweed.Point.Spatial.With.Coordinates;

namespace Tumbleweed.Point.Spatial.Implementation.Real.Arithmetic;

public sealed class NegativePoint : Envelope<Any>
{
	public NegativePoint
	(
		Any<Any> point
	) : base
	(
		new Unique<Any>(
			new NegativeReal(new XOfPoint(point)),
			new NegativeReal(new YOfPoint(point)),
			new NegativeReal(new ZOfPoint(point)))
	)
	{
	}
}