using Tumbleweed.Number.Natural.Scalar;
using Tumbleweed.Point.Spatial;
using Tumbleweed.Point.Spatial.Coordinate;
using Tumbleweed.Point.Spatial.Coordinate.Z.Actual;

namespace Tumbleweed.Number.Natural.Point.Spatial.Coordinate;

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