using Tumbleweed.Number.Real;
using Tumbleweed.Number.Real.Arithmetic;
using Tumbleweed.Spatial.Point.Real.Coordinate;

namespace Tumbleweed.Spatial.Point.Real.Arithmetic;

public sealed class ProductOfPoints : PointEnvelope<IReal>
{
	public ProductOfPoints
	(
		params IPoint<IReal>[] spatials
	) : this
	(
		new List<IPoint<IReal>>(spatials)
	)
	{
	}

	public ProductOfPoints
	(
		IEnumerable<IPoint<IReal>> spatials
	) : this
	(
		new List<IPoint<IReal>>(spatials)
	)
	{
	}
	
	public ProductOfPoints
	(
		ICollection<IPoint<IReal>> spatials
	) : base
	(
		new PointWithCoordinates<IReal>(
			new ProductOfReals(new XOfPoints(spatials)),
			new ProductOfReals(new YOfPoints(spatials)),
			new ProductOfReals(new ZOfPoints(spatials)))
	)
	{
	}
}