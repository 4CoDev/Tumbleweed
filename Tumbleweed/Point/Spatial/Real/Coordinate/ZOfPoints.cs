using Tumbleweed.Enumerable;
using Tumbleweed.Number.Real;
using Tumbleweed.Point.Spatial.Coordinate;
using Tumbleweed.Point.Spatial.Coordinate.Z.Actual;

namespace Tumbleweed.Point.Spatial.Real.Coordinate;

public sealed class ZOfPoints : Tumbleweed.Enumerable.Envelope<Any>
{
	public ZOfPoints(params Any<Any>[] points) : this
	(
		new Concatenated<Any<Any>>(points)
	)
	{
	}
	
	public ZOfPoints
	(
		IEnumerable<Any<Any>> spatials
	) : base
	(
		new Multiple<Any>(spatials)
	)
	{
	}
}