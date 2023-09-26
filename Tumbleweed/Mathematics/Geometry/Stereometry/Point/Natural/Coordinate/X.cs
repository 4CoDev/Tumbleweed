using Tumbleweed.Mathematics.Geometry.Stereometry.Point.Generic;
using Tumbleweed.Mathematics.Geometry.Stereometry.Point.Generic.Coordinate.X.Actual;
using Tumbleweed.Mathematics.Number.Natural;
using Tumbleweed.Mathematics.Number.Natural.Scalar;

namespace Tumbleweed.Mathematics.Geometry.Stereometry.Point.Natural.Coordinate;

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