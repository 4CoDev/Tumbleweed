using Tumbleweed.Points.Spatial;
using Tumbleweed.Points.Spatial.Coordinates;

namespace Tumbleweed.Numbers.Integers.Natural.Spatial.Coordinates;

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