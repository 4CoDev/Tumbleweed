using Tumbleweed.Number.Real;
using Tumbleweed.Number.Real.Scalar;
using Tumbleweed.Point.Spatial.Coordinate.Z.Actual;

namespace Tumbleweed.Point.Spatial.Implementation.Real.Coordinate;

public sealed class ZOfPoint : Envelope
{
	public ZOfPoint(Any<Any> point) : base
	(
		new Value(
			new One<Any>(point))
	)
	{
	}
}