using Tumbleweed.Spatial.Point;
using Tumbleweed.Spatial.Point.Coordinate;

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