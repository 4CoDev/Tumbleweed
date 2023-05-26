using Tumbleweed.Point.Spatial;
using Tumbleweed.Point.Spatial.Coordinate;

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