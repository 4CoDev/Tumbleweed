using Tumbleweed.Numbers.Spatial;
using Tumbleweed.Numbers.Spatial.Coordinates;

namespace Tumbleweed.Numbers.Integers.Natural.Spatial.Coordinates;

public sealed class ZOfSpatial : NaturalEnvelope
{
	public ZOfSpatial(ISpatial<INatural> spatial) : base
	(
		new NaturalOfScalar(
			new ZOfSpatial<INatural>(spatial))
	)
	{
	}
}