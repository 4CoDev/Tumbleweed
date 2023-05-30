using Tumbleweed.Spatial.Point;
using Tumbleweed.Spatial.Point.Coordinate;

namespace Tumbleweed.Number.Integer.Natural.Spatial.Coordinate;

public sealed class ZOfSpatial : NaturalEnvelope
{
	public ZOfSpatial(IPoint<INatural> point) : base
	(
		new NaturalOfScalar(
			new ZOfPoint<INatural>(point))
	)
	{
	}
}