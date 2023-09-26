using Tumbleweed.Mathematics.Arithmetic.Real.Product.Scalar.Of;
using Tumbleweed.Mathematics.Geometry.Planimetry.Point.Real.Coordinate;
using Tumbleweed.Mathematics.Geometry.Planimetry.Point.With.Coordinate.Definition;
using Tumbleweed.Mathematics.Number.Real;

namespace Tumbleweed.Mathematics.Geometry.Planimetry.Point.Real.Arithmetic;

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
		new Unique<Any>(
			new Multiple(new X(points)),
			new Multiple(new Y(points)))
	)
	{
	}
}