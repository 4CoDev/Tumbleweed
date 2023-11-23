using Tumbleweed.Mathematics.Arithmetic.Numerical.Real.Quotient.Scalar.Of;
using Tumbleweed.Mathematics.Number.Real;
using Tumbleweed.Mathematics.Vector.Planar.Generic;
using Tumbleweed.Mathematics.Vector.Planar.Generic.With.Coordinate.Definition;
using Tumbleweed.Mathematics.Vector.Planar.Real.Coordinate;

namespace Tumbleweed.Mathematics.Vector.Planar.Real.Arithmetic;

public sealed class QuotientOfPoints : Envelope<Any>
{
	public QuotientOfPoints(params Any<Any>[] points) : this
	(
		new List<Any<Any>>(points)
	)
	{
	}

	public QuotientOfPoints(IEnumerable<Any<Any>> points) : this
	(
		new List<Any<Any>>(points)
	)
	{
	}
	
	public QuotientOfPoints(ICollection<Any<Any>> points) : base
	(
		new Unique<Any>(
			new Multiple(new X(points)),
			new Multiple(new Y(points)))
	)
	{
	}
}