using Tumbleweed.Point.Spatial;
using Tumbleweed.Point.Spatial.Coordinate;

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