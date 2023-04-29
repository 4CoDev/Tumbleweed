using Tumbleweed.Numerics.Spatial;

namespace Tumbleweed.Numerics.Fractional.Spatial;

public sealed class SpatialWithCoordinates :
	SpatialEnvelope<IFractional>
{
	public SpatialWithCoordinates
	(
		IFractional x,
		IFractional y,
		IFractional z
	) : base
	(
		new SpatialWithCoordinates<IFractional>(x, y, z)
	)
	{
	}
}