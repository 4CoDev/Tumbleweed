using Tumbleweed.Points.Spatial.Coordinates;

namespace Tumbleweed.Points.Spatial;

public sealed class LazyPoint<T> : PointEnvelope<T>
{
	public LazyPoint(IPoint<T> point) : base
	(
		new PointWithCoordinates<T>(
			new LazyXOfPoint<T>(point),
			new LazyYOfPoint<T>(point),
			new LazyZOfPoint<T>(point))
	)
	{
	}
}