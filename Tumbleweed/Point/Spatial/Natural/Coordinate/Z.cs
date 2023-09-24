using Tumbleweed.Mathematics.Number.Natural;
using Tumbleweed.Mathematics.Number.Natural;
using Tumbleweed.Mathematics.Number.Natural.Scalar;
using Tumbleweed.Point.Spatial.Generic;
using Tumbleweed.Point.Spatial.Generic.Coordinate.Z.Actual;

namespace Tumbleweed.Point.Spatial.Natural.Coordinate;

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