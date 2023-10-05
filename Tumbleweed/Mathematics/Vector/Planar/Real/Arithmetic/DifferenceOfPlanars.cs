using Tumbleweed.Mathematics.Arithmetic.Numerical.Real.Difference.Just.Of;
using Tumbleweed.Mathematics.Number.Real;
using Tumbleweed.Mathematics.Vector.Planar.Generic;
using Tumbleweed.Mathematics.Vector.Planar.Generic.With.Coordinate.Definition;
using Tumbleweed.Mathematics.Vector.Planar.Real.Coordinate;

namespace Tumbleweed.Mathematics.Vector.Planar.Real.Arithmetic;

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