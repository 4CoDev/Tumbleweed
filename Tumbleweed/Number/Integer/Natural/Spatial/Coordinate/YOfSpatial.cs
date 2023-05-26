using Tumbleweed.Point.Spatial;
using Tumbleweed.Point.Spatial.Coordinate;

namespace Tumbleweed.Number.Integer.Natural.Spatial.Coordinate;

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