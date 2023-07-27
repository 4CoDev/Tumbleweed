using Tumbleweed.Number.Real;
using Tumbleweed.Number.Real.Scalar;
using Tumbleweed.Point.Spatial.Coordinate;
using Tumbleweed.Point.Spatial.Coordinate.Y.Actual;

namespace Tumbleweed.Point.Spatial.Real.Coordinate;

public sealed class YOfPoint : Envelope
{
	public YOfPoint(Any<Any> point) : base
	(
		new Value(
			new One<Any>(point))
	)
	{
	}
}