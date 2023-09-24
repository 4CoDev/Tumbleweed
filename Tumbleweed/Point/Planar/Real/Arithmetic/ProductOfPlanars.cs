using Tumbleweed.Mathematics.Arithmetic.Real.Product.Scalar.Of;
using Tumbleweed.Mathematics.Number.Real;
using Tumbleweed.Mathematics.Number.Real;
using Tumbleweed.Point.Planar.Real.Coordinate;
using Tumbleweed.Point.Planar.With;

namespace Tumbleweed.Point.Planar.Real.Arithmetic;

public sealed class ProductOfPoints : Envelope<Any>
{
	public ProductOfPoints(params Any<Any>[] points) : this
	(
		new List<Any<Any>>(points)
	)
	{
	}

	public ProductOfPoints(IEnumerable<Any<Any>> points) : this
	(
		new List<Any<Any>>(points)
	)
	{
	}
	
	public ProductOfPoints(ICollection<Any<Any>> points) : base
	(
		new Coordinates<Any>(
			new Multiple(new X(points)),
			new Multiple(new Y(points)))
	)
	{
	}
}