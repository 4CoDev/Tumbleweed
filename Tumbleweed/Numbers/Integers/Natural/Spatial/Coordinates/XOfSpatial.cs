using Tumbleweed.Numbers.Spatial;
using Tumbleweed.Numbers.Spatial.Coordinates;

namespace Tumbleweed.Numbers.Integers.Natural.Spatial.Coordinates;

public sealed class XOfSpatial : NaturalEnvelope
{
	public XOfSpatial(ISpatial<INatural> spatial) : base
	(
		new NaturalOfScalar(
			new XOfSpatial<INatural>(spatial))
	)
	{
	}
}