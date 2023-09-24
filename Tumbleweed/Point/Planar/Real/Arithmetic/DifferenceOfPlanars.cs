using Tumbleweed.Mathematics.Arithmetic.Real.Difference.Just.Of;
using Tumbleweed.Mathematics.Number.Real;
using Tumbleweed.Mathematics.Number.Real;
using Tumbleweed.Point.Planar.Real.Coordinate;
using Tumbleweed.Point.Planar.With;

namespace Tumbleweed.Point.Planar.Real.Arithmetic;

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
		new Coordinates<Any>(
			new Multiple(new X(points)),
			new Multiple(new Y(points)))
	)
	{
	}
}