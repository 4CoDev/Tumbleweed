using Tumbleweed.Points.Spatial;
using Tumbleweed.Points.Spatial.Coordinates;

namespace Tumbleweed.Numbers.Integers.Natural.Spatial.Coordinates;

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