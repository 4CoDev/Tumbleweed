using Tumbleweed.Numerics.Fractional.Arithmetics;
using Tumbleweed.Numerics.Spatial;

namespace Tumbleweed.Numerics.Fractional.Spatials.Arithmetics;

public sealed class DifferenceOfSpatials : SpatialEnvelope<IFractional>
{
	public DifferenceOfSpatials(params ISpatial<IFractional>[] spatials) : this
	(
		new List<ISpatial<IFractional>>(spatials)
	)
	{
	}

	public DifferenceOfSpatials(IEnumerable<ISpatial<IFractional>> spatials) : this
	(
		new List<ISpatial<IFractional>>(spatials)
	)
	{
	}
	
	public DifferenceOfSpatials(ICollection<ISpatial<IFractional>> spatials) : base
	(
		new SpatialWithValues<IFractional>(
			new DifferenceOfFractionals(new XOfSpatials(spatials)),
			new DifferenceOfFractionals(new YOfSpatials(spatials)),
			new DifferenceOfFractionals(new ZOfSpatials(spatials)))
	)
	{
	}
}