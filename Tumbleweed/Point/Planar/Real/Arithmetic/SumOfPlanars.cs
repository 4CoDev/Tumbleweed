using Tumbleweed.Mathematics.Arithmetic.Real.Sum.Scalar.Of;
using Tumbleweed.Mathematics.Number.Real;
using Tumbleweed.Mathematics.Number.Real;
using Tumbleweed.Point.Planar.Real.Coordinate;
using Tumbleweed.Point.Planar.With;

namespace Tumbleweed.Point.Planar.Real.Arithmetic;

public sealed class SumOfPoints : Envelope<Any>
{
	public SumOfPoints(params Any<Any>[] points) : this
	(
		new List<Any<Any>>(points)
	)
	{
	}

	public SumOfPoints(IEnumerable<Any<Any>> points) : this
	(
		new List<Any<Any>>(points)
	)
	{
	}
	
	public SumOfPoints(ICollection<Any<Any>> points) : base
	(
		new Coordinates<Any>(
			new Multiple(new X(points)),
			new Multiple(new Y(points)))
	)
	{
	}
}