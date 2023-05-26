using Tumbleweed.Point.Spatial;

namespace Tumbleweed.Number.Integer.Natural.Spatial;

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