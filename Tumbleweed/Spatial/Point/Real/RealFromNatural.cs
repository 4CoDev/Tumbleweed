using Tumbleweed.Number.Integer.Natural;
using Tumbleweed.Number.Integer.Natural.Spatial.Coordinate;
using Tumbleweed.Number.Real;

namespace Tumbleweed.Spatial.Point.Real;

using RealNumberFromNatural = Number.Real.RealFromNatural;
using XOfNaturalSpatial = XOfSpatial;
using YOfNaturalSpatial = YOfSpatial;
using ZOfNaturalSpatial = ZOfSpatial;

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