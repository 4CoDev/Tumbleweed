using Tumbleweed.Numerics.Fractional.Arithmetics;
using Tumbleweed.Numerics.Fractional.Spatial.Coordinates;
using Tumbleweed.Numerics.Spatial;

namespace Tumbleweed.Numerics.Fractional.Spatial.Arithmetics;

public sealed class QuotientOfSpatials : SpatialEnvelope<IFractional>
{
	public QuotientOfSpatials
	(
		params ISpatial<IFractional>[] spatials
	) : this
	(
		new List<ISpatial<IFractional>>(spatials)
	)
	{
	}

	public QuotientOfSpatials
	(
		IEnumerable<ISpatial<IFractional>> spatials
	) : this
	(
		new List<ISpatial<IFractional>>(spatials)
	)
	{
	}
	
	public QuotientOfSpatials
	(
		ICollection<ISpatial<IFractional>> spatials
	) : base
	(
		new SpatialWithCoordinates<IFractional>(
			new QuotientOfFractionals(new XOfSpatials(spatials)),
			new QuotientOfFractionals(new YOfSpatials(spatials)),
			new QuotientOfFractionals(new ZOfSpatials(spatials)))
	)
	{
	}
}