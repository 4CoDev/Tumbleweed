using Tumbleweed.Numerics.Spatial;
using Tumbleweed.Numerics.Spatial.Coordinates;

namespace Tumbleweed.Numerics.Fractional.Spatial.Coordinates;

public sealed class YOfSpatial : FractionalEnvelope
{
	public YOfSpatial(ISpatial<IFractional> spatial) : base
	(
		new FractionalOfScalar(
			new YOfSpatial<IFractional>(spatial))
	)
	{
	}
}