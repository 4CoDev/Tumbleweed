using Tumbleweed.Numerics.Decimals.Arithmetics;
using Tumbleweed.Numerics.Spatial;

namespace Tumbleweed.Numerics.Decimals.Spatial.Arithmetics;

public sealed class ProductOfSpatials : SpatialEnvelope<IDecimal>
{
	public ProductOfSpatials(params ISpatial<IDecimal>[] spatials) : this
	(
		new List<ISpatial<IDecimal>>(spatials)
	)
	{
	}

	public ProductOfSpatials(IEnumerable<ISpatial<IDecimal>> spatials) : this
	(
		new List<ISpatial<IDecimal>>(spatials)
	)
	{
	}
	
	public ProductOfSpatials(ICollection<ISpatial<IDecimal>> spatials) : base
	(
		new SpatialWithValues<IDecimal>(
			new ProductOfDecimals(new XOfSpatials(spatials)),
			new ProductOfDecimals(new YOfSpatials(spatials)),
			new ProductOfDecimals(new ZOfSpatials(spatials)))
	)
	{
	}
}