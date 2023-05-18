using Tumbleweed.Points.Spatial;

namespace Tumbleweed.Numbers.Integers.Natural.Spatial;

public sealed class PointWithCoordinates : PointEnvelope<INatural>
{
	public PointWithCoordinates
	(
		INatural x,
		INatural y,
		INatural z
	) : base
	(
		new PointWithCoordinates<INatural>(x, y, z)
	)
	{
	}
}