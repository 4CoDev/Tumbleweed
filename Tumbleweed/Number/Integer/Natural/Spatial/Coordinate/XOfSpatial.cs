using Tumbleweed.Spatial.Point;
using Tumbleweed.Spatial.Point.Coordinate;

namespace Tumbleweed.Number.Integer.Natural.Spatial.Coordinate;

public sealed class XOfSpatial : NaturalEnvelope
{
	public XOfSpatial(IPoint<INatural> point) : base
	(
		new NaturalOfScalar(
			new XOfPoint<INatural>(point))
	)
	{
	}
}