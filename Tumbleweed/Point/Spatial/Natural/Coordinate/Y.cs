using Tumbleweed.Mathematics.Number.Natural;
using Tumbleweed.Mathematics.Number.Natural;
using Tumbleweed.Mathematics.Number.Natural.Scalar;
using Tumbleweed.Point.Spatial.Generic;
using Tumbleweed.Point.Spatial.Generic.Coordinate.Y.Actual;

namespace Tumbleweed.Point.Spatial.Natural.Coordinate;

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