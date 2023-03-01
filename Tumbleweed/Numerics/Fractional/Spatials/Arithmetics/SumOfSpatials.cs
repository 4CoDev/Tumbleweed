using Tumbleweed.Numerics.Fractional.Arithmetics;
using Tumbleweed.Numerics.Spatial;

namespace Tumbleweed.Numerics.Fractional.Spatials.Arithmetics;

public sealed class SumOfSpatials : SpatialEnvelope<IFractional>
{
	public SumOfSpatials(params ISpatial<IFractional>[] spatials) : this
	(
		new List<ISpatial<IFractional>>(spatials)
	)
	{
	}

	public SumOfSpatials(IEnumerable<ISpatial<IFractional>> spatials) : this
	(
		new List<ISpatial<IFractional>>(spatials)
	)
	{
	}
	
	public SumOfSpatials(ICollection<ISpatial<IFractional>> spatials) : base
	(
		new SpatialWithValues<IFractional>(
			new SumOfFractionals(new XOfSpatials(spatials)),
			new SumOfFractionals(new YOfSpatials(spatials)),
			new SumOfFractionals(new ZOfSpatials(spatials)))
	)
	{
	}
}