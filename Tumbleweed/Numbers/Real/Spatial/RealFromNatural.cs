namespace Tumbleweed.Numbers.Real.Spatial;

using Integers.Natural;
using Tumbleweed.Numbers.Spatial;
using RealNumberFromNatural = Real.RealFromNatural;
using XOfNaturalSpatial = Integers.Natural.Spatial.Coordinates.XOfSpatial;
using YOfNaturalSpatial = Integers.Natural.Spatial.Coordinates.YOfSpatial;
using ZOfNaturalSpatial = Integers.Natural.Spatial.Coordinates.ZOfSpatial;

public sealed class RealFromNatural : SpatialEnvelope<IReal>
{
	public RealFromNatural(ISpatial<INatural> natural) : base
	(
		new SpatialWithCoordinates(
			new RealNumberFromNatural(new XOfNaturalSpatial(natural)),
			new RealNumberFromNatural(new YOfNaturalSpatial(natural)),
			new RealNumberFromNatural(new ZOfNaturalSpatial(natural)))
	)
	{
	}
}