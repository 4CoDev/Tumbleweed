using Tumbleweed.Enumerable;
using Tumbleweed.Number.Real;
using Tumbleweed.Point.Spatial.Coordinate;
using Tumbleweed.Point.Spatial.Coordinate.Y.Actual;

namespace Tumbleweed.Point.Spatial.Real.Coordinate;

public sealed class YOfPoints : Tumbleweed.Enumerable.Envelope<Any>
{
	public YOfPoints(params Any<Any>[] points) : this
	(
		new Concatenated<Any<Any>>(points)
	)
	{
	}
	
	public YOfPoints
	(
		IEnumerable<Any<Any>> points
	) : base
	(
		new Multiple<Any>(points)
	)
	{
	}
}