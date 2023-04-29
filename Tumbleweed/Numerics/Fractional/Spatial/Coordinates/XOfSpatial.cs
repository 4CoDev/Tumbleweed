using Tumbleweed.Numerics.Spatial;
using Tumbleweed.Numerics.Spatial.Coordinates;

namespace Tumbleweed.Numerics.Fractional.Spatial.Coordinates;

public sealed class XOfSpatial : FractionalEnvelope
{
	public XOfSpatial(ISpatial<IFractional> spatial) : base
	(
		new FractionalOfScalar(
			new XOfSpatial<IFractional>(spatial))
	)
	{
	}
}