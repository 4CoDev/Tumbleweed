using Tumbleweed.Enumerable;
using Tumbleweed.Number.Real;
using Tumbleweed.Point.Spatial.Coordinate.X.Actual;

namespace Tumbleweed.Point.Spatial.Implementation.Real.Coordinate;

public sealed class XOfPoints : Tumbleweed.Enumerable.Envelope<Any>
{
	public XOfPoints(params Any<Any>[] points) : this
	(
		new Concatenated<Any<Any>>(points)
	)
	{
	}
	
	public XOfPoints
	(
		IEnumerable<Any<Any>> points
	) : base
	(
		new Multiple<Any>(points)
	)
	{
	}
}