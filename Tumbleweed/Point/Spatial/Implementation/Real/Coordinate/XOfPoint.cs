using Tumbleweed.Number.Real;
using Tumbleweed.Number.Real.Scalar;
using Tumbleweed.Point.Spatial.Coordinate.X.Actual;

namespace Tumbleweed.Point.Spatial.Implementation.Real.Coordinate;

public sealed class XOfPoint : Envelope
{
	public XOfPoint(Any<Any> point) : base
	(
		new Value(
			new One<Any>(point))
	)
	{
	}
}