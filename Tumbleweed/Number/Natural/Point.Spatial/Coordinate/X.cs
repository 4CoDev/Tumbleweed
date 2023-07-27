using Tumbleweed.Number.Natural.Scalar;
using Tumbleweed.Point.Spatial;
using Tumbleweed.Point.Spatial.Coordinate;
using Tumbleweed.Point.Spatial.Coordinate.X.Actual;

namespace Tumbleweed.Number.Natural.Point.Spatial.Coordinate;

public sealed class X : Envelope
{
	public X(Any<Any> point) : base
	(
		new Value(
			new One<Any>(point))
	)
	{
	}
}