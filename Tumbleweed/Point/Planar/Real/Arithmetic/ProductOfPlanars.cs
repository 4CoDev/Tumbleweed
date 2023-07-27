using Tumbleweed.Number.Real;
using Tumbleweed.Number.Real.Arithmetic;
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
			new ProductOfReals(new X(points)),
			new ProductOfReals(new Y(points)))
	)
	{
	}
}