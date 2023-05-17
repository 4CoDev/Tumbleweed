using Tumbleweed.Numbers.Real.Arithmetics;
using Tumbleweed.Numbers.Real.Spatial.Coordinates;
using Tumbleweed.Points.Spatial;

namespace Tumbleweed.Numbers.Real.Spatial.Arithmetics;

public sealed class ProductOfSpatials : SpatialEnvelope<IReal>
{
	public ProductOfSpatials
	(
		params ISpatial<IReal>[] spatials
	) : this
	(
		new List<ISpatial<IReal>>(spatials)
	)
	{
	}

	public ProductOfSpatials
	(
		IEnumerable<ISpatial<IReal>> spatials
	) : this
	(
		new List<ISpatial<IReal>>(spatials)
	)
	{
	}
	
	public ProductOfSpatials
	(
		ICollection<ISpatial<IReal>> spatials
	) : base
	(
		new SpatialWithCoordinates<IReal>(
			new ProductOfReals(new XOfSpatials(spatials)),
			new ProductOfReals(new YOfSpatials(spatials)),
			new ProductOfReals(new ZOfSpatials(spatials)))
	)
	{
	}
}