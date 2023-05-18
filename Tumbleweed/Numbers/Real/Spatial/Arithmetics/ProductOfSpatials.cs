using Tumbleweed.Numbers.Real.Arithmetics;
using Tumbleweed.Numbers.Real.Spatial.Coordinates;
using Tumbleweed.Points.Spatial;

namespace Tumbleweed.Numbers.Real.Spatial.Arithmetics;

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
			new ProductOfReals(new XOfSpatials(spatials)),
			new ProductOfReals(new YOfSpatials(spatials)),
			new ProductOfReals(new ZOfSpatials(spatials)))
	)
	{
	}
}