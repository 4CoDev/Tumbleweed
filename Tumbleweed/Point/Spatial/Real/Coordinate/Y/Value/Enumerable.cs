using Tumbleweed.Enumerable;
using Tumbleweed.Mathematics.Number.Real;
using Tumbleweed.Mathematics.Number.Real;
using Tumbleweed.Point.Spatial.Generic;
using Tumbleweed.Point.Spatial.Generic.Coordinate.Y.Actual;

namespace Tumbleweed.Point.Spatial.Real.Coordinate.Y.Value;

public sealed class Enumerable : Tumbleweed.Enumerable.Envelope<Any>
{
	public Enumerable(params Any<Any>[] points) : this
	(
		new Concatenated<Any<Any>>(points)
	)
	{
	}
	
	public Enumerable
	(
		IEnumerable<Any<Any>> points
	) : base
	(
		new Multiple<Any>(points)
	)
	{
	}
}