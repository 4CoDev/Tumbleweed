using Tumbleweed.Points.Spatial;

namespace Tumbleweed.Numbers.Integers.Natural.Spatial;

public sealed class SpatialWithCoordinates : SpatialEnvelope<INatural>
{
	public SpatialWithCoordinates
	(
		INatural x,
		INatural y,
		INatural z
	) : base
	(
		new SpatialWithCoordinates<INatural>(x, y, z)
	)
	{
	}
}