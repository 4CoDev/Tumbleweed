using Tumbleweed.Numerics.Decimals.Arithmetics;
using Tumbleweed.Numerics.Spatial;

namespace Tumbleweed.Numerics.Decimals.Spatial.Arithmetics;

public sealed class SumOfSpatials : SpatialEnvelope<IDecimal>
{
	public SumOfSpatials(params ISpatial<IDecimal>[] spatials) : this
	(
		new List<ISpatial<IDecimal>>(spatials)
	)
	{
	}

	public SumOfSpatials(IEnumerable<ISpatial<IDecimal>> spatials) : this
	(
		new List<ISpatial<IDecimal>>(spatials)
	)
	{
	}
	
	public SumOfSpatials(ICollection<ISpatial<IDecimal>> spatials) : base
	(
		new SpatialWithValues<IDecimal>(
			new SumOfDecimals(new XOfSpatials(spatials)),
			new SumOfDecimals(new YOfSpatials(spatials)),
			new SumOfDecimals(new ZOfSpatials(spatials)))
	)
	{
	}
}