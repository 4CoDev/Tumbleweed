using Tumbleweed.Numerics.Decimals.Arithmetics;
using Tumbleweed.Numerics.Spatial;

namespace Tumbleweed.Numerics.Decimals.Spatial.Arithmetics;

public sealed class DifferenceOfSpatials : SpatialEnvelope<IDecimal>
{
	public DifferenceOfSpatials(params ISpatial<IDecimal>[] spatials) : this
	(
		new List<ISpatial<IDecimal>>(spatials)
	)
	{
	}

	public DifferenceOfSpatials(IEnumerable<ISpatial<IDecimal>> spatials) : this
	(
		new List<ISpatial<IDecimal>>(spatials)
	)
	{
	}
	
	public DifferenceOfSpatials(ICollection<ISpatial<IDecimal>> spatials) : base
	(
		new SpatialWithValues<IDecimal>(
			new DifferenceOfDecimals(new XOfSpatials(spatials)),
			new DifferenceOfDecimals(new YOfSpatials(spatials)),
			new DifferenceOfDecimals(new ZOfSpatials(spatials)))
	)
	{
	}
}