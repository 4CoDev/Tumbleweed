using Tumbleweed.Numerics.Spatial;
using Tumbleweed.Numerics.Spatial.Coordinates;

namespace Tumbleweed.Numerics.Fractional.Spatial.Coordinates;

public sealed class ZOfSpatial : FractionalEnvelope
{
	public ZOfSpatial(ISpatial<IFractional> spatial) : base
	(
		new FractionalOfScalar(
			new ZOfSpatial<IFractional>(spatial))
	)
	{
	}
}