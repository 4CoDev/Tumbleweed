using Tumbleweed.Numbers.Spatial;
using Tumbleweed.Numbers.Spatial.Coordinates;

namespace Tumbleweed.Numbers.Integers.Natural.Spatial.Coordinates;

public sealed class YOfSpatial : NaturalEnvelope
{
	public YOfSpatial(ISpatial<INatural> spatial) : base
	(
		new NaturalOfScalar(
			new YOfSpatial<INatural>(spatial))
	)
	{
	}
}