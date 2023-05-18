using Tumbleweed.Points.Spatial;
using Tumbleweed.Points.Spatial.Coordinates;

namespace Tumbleweed.Numbers.Integers.Natural.Spatial.Coordinates;

public sealed class YOfSpatial : NaturalEnvelope
{
	public YOfSpatial(IPoint<INatural> point) : base
	(
		new NaturalOfScalar(
			new YOfPoint<INatural>(point))
	)
	{
	}
}