using Tumbleweed.Mathematics.Number.Natural;
using Tumbleweed.Mathematics.Number.Natural.Scalar;
using Tumbleweed.Mathematics.Vector.Spatial.Generic;
using Tumbleweed.Mathematics.Vector.Spatial.Generic.Coordinate.Y.Actual;

namespace Tumbleweed.Mathematics.Vector.Spatial.Natural.Coordinate;

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