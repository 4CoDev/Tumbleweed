using Tumbleweed.Numerics.Fractional.Arithmetics;
using Tumbleweed.Numerics.Fractional.Spatial.Coordinates;
using Tumbleweed.Numerics.Spatial;

namespace Tumbleweed.Numerics.Fractional.Spatial.Arithmetics;

public sealed class NegativeSpatial : SpatialEnvelope<IFractional>
{
	public NegativeSpatial
	(
		ISpatial<IFractional> spatial
	) : base
	(
		new SpatialWithCoordinates<IFractional>(
			new NegativeFractional(new XOfSpatial(spatial)),
			new NegativeFractional(new YOfSpatial(spatial)),
			new NegativeFractional(new ZOfSpatial(spatial)))
	)
	{
	}
}