using Tumbleweed.Numerics.Fractional.Arithmetics;
using Tumbleweed.Numerics.Spatial;

namespace Tumbleweed.Numerics.Fractional.Spatials.Arithmetics;

public sealed class ProductOfSpatials : SpatialEnvelope<IFractional>
{
	public ProductOfSpatials(params ISpatial<IFractional>[] spatials) : this
	(
		new List<ISpatial<IFractional>>(spatials)
	)
	{
	}

	public ProductOfSpatials(IEnumerable<ISpatial<IFractional>> spatials) : this
	(
		new List<ISpatial<IFractional>>(spatials)
	)
	{
	}
	
	public ProductOfSpatials(ICollection<ISpatial<IFractional>> spatials) : base
	(
		new SpatialWithValues<IFractional>(
			new ProductOfFractionals(new XOfSpatials(spatials)),
			new ProductOfFractionals(new YOfSpatials(spatials)),
			new ProductOfFractionals(new ZOfSpatials(spatials)))
	)
	{
	}
}