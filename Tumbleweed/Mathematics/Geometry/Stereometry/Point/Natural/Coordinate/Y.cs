using Tumbleweed.Mathematics.Geometry.Stereometry.Point.Generic;
using Tumbleweed.Mathematics.Geometry.Stereometry.Point.Generic.Coordinate.Y.Actual;
using Tumbleweed.Mathematics.Number.Natural;
using Tumbleweed.Mathematics.Number.Natural.Scalar;

namespace Tumbleweed.Mathematics.Geometry.Stereometry.Point.Natural.Coordinate;

public sealed class Y : Envelope
{
	public Y(Any<Any> point) : base
	(
		new Value(
			new One<Any>(point))
	)
	{
	}
}