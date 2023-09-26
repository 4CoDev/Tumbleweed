using Tumbleweed.Mathematics.Arithmetic.Real.Difference.Just.Of;
using Tumbleweed.Mathematics.Geometry.Planimetry.Point.Real.Coordinate;
using Tumbleweed.Mathematics.Geometry.Planimetry.Point.With.Coordinate.Definition;
using Tumbleweed.Mathematics.Number.Real;

namespace Tumbleweed.Mathematics.Geometry.Planimetry.Point.Real.Arithmetic;

public sealed class DifferenceOfPoints : Envelope<Any>
{
	public DifferenceOfPoints(params Any<Any>[] points) : this
	(
		new List<Any<Any>>(points)
	)
	{
	}

	public DifferenceOfPoints(IEnumerable<Any<Any>> points) : this
	(
		new List<Any<Any>>(points)
	)
	{
	}
	
	public DifferenceOfPoints(ICollection<Any<Any>> points) : base
	(
		new Unique<Any>(
			new Multiple(new X(points)),
			new Multiple(new Y(points)))
	)
	{
	}
}