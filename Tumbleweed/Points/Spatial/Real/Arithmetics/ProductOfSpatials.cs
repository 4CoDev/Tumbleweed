using Tumbleweed.Numbers.Real;
using Tumbleweed.Numbers.Real.Arithmetics;
using Tumbleweed.Points.Spatial.Real.Coordinates;

namespace Tumbleweed.Points.Spatial.Real.Arithmetics;

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