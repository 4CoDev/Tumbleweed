using Tumbleweed.Numerics.Fractional.Arithmetics;
using Tumbleweed.Numerics.Fractional.Spatial.Coordinates;
using Tumbleweed.Numerics.Spatial;

namespace Tumbleweed.Numerics.Fractional.Spatial.Arithmetics;

public sealed class ProductOfSpatials : SpatialEnvelope<IFractional>
{
	public ProductOfSpatials
	(
		params ISpatial<IFractional>[] spatials
	) : this
	(
		new List<ISpatial<IFractional>>(spatials)
	)
	{
	}

	public ProductOfSpatials
	(
		IEnumerable<ISpatial<IFractional>> spatials
	) : this
	(
		new List<ISpatial<IFractional>>(spatials)
	)
	{
	}
	
	public ProductOfSpatials
	(
		ICollection<ISpatial<IFractional>> spatials
	) : base
	(
		new SpatialWithCoordinates<IFractional>(
			new ProductOfFractionals(new XOfSpatials(spatials)),
			new ProductOfFractionals(new YOfSpatials(spatials)),
			new ProductOfFractionals(new ZOfSpatials(spatials)))
	)
	{
	}
}