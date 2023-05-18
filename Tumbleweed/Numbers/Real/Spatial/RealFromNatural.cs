using Tumbleweed.Points.Spatial;

namespace Tumbleweed.Numbers.Real.Spatial;

using Integers.Natural;
using RealNumberFromNatural = Real.RealFromNatural;
using XOfNaturalSpatial = Integers.Natural.Spatial.Coordinates.XOfSpatial;
using YOfNaturalSpatial = Integers.Natural.Spatial.Coordinates.YOfSpatial;
using ZOfNaturalSpatial = Integers.Natural.Spatial.Coordinates.ZOfSpatial;

public sealed class RealFromNatural : PointEnvelope<IReal>
{
	public RealFromNatural(IPoint<INatural> natural) : base
	(
		new PointWithCoordinates(
			new RealNumberFromNatural(new XOfNaturalSpatial(natural)),
			new RealNumberFromNatural(new YOfNaturalSpatial(natural)),
			new RealNumberFromNatural(new ZOfNaturalSpatial(natural)))
	)
	{
	}
}