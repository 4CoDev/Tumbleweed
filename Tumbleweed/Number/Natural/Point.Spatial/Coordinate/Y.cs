using Tumbleweed.Number.Natural.Scalar;
using Tumbleweed.Point.Spatial;
using Tumbleweed.Point.Spatial.Coordinate;
using Tumbleweed.Point.Spatial.Coordinate.Y.Actual;

namespace Tumbleweed.Number.Natural.Point.Spatial.Coordinate;

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