using Tumbleweed.Number.Natural;
using Tumbleweed.Number.Natural.Scalar;
using Tumbleweed.Point.Spatial.Generic;
using Tumbleweed.Point.Spatial.Generic.Coordinate.X.Actual;

namespace Tumbleweed.Point.Spatial.Natural.Coordinate;

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