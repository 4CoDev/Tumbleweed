using Tumbleweed.Numbers.Integers.Natural;
using Tumbleweed.Numbers.Real;

namespace Tumbleweed.Points.Spatial.Real;

using RealNumberFromNatural = Numbers.Real.RealFromNatural;
using XOfNaturalSpatial = Numbers.Integers.Natural.Spatial.Coordinates.XOfSpatial;
using YOfNaturalSpatial = Numbers.Integers.Natural.Spatial.Coordinates.YOfSpatial;
using ZOfNaturalSpatial = Numbers.Integers.Natural.Spatial.Coordinates.ZOfSpatial;

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