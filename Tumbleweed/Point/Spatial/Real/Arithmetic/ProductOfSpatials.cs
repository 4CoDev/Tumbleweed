using Tumbleweed.Number.Real;
using Tumbleweed.Number.Real.Arithmetic;
using Tumbleweed.Point.Spatial.Real.Coordinate;
using Tumbleweed.Point.Spatial.With.Coordinates;

namespace Tumbleweed.Point.Spatial.Real.Arithmetic;

public sealed class ProductOfPoints : Envelope<Any>
{
	public ProductOfPoints
	(
		params Any<Any>[] spatials
	) : this
	(
		new List<Any<Any>>(spatials)
	)
	{
	}

	public ProductOfPoints
	(
		IEnumerable<Any<Any>> spatials
	) : this
	(
		new List<Any<Any>>(spatials)
	)
	{
	}
	
	public ProductOfPoints
	(
		ICollection<Any<Any>> spatials
	) : base
	(
		new Unique<Any>(
			new ProductOfReals(new XOfPoints(spatials)),
			new ProductOfReals(new YOfPoints(spatials)),
			new ProductOfReals(new ZOfPoints(spatials)))
	)
	{
	}
}