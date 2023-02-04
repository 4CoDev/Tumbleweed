using Tumbleweed.Numerics.Decimals.Arithmetics;
using Tumbleweed.Numerics.Spatial;

namespace Tumbleweed.Numerics.Decimals.Spatials.Arithmetics;

public sealed class QuotientOfSpatials : SpatialEnvelope<IDecimal>
{
	public QuotientOfSpatials(params ISpatial<IDecimal>[] spatials) : this
	(
		new List<ISpatial<IDecimal>>(spatials)
	)
	{
	}

	public QuotientOfSpatials(IEnumerable<ISpatial<IDecimal>> spatials) : this
	(
		new List<ISpatial<IDecimal>>(spatials)
	)
	{
	}
	
	public QuotientOfSpatials(ICollection<ISpatial<IDecimal>> spatials) : base
	(
		new SpatialWithValues<IDecimal>(
			new QuotientOfDecimals(new XOfSpatials(spatials)),
			new QuotientOfDecimals(new YOfSpatials(spatials)),
			new QuotientOfDecimals(new ZOfSpatials(spatials)))
	)
	{
	}
}