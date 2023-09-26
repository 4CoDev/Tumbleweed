using Tumbleweed.Mathematics.Geometry.Stereometry.Point.Generic;
using Tumbleweed.Mathematics.Geometry.Stereometry.Point.Generic.Coordinate.Z.Actual;
using Tumbleweed.Mathematics.Number.Natural;
using Tumbleweed.Mathematics.Number.Natural.Scalar;

namespace Tumbleweed.Mathematics.Geometry.Stereometry.Point.Natural.Coordinate;

public sealed class Z : Envelope
{
	public Z(Any<Any> point) : base
	(
		new Value(
			new One<Any>(point))
	)
	{
	}
}