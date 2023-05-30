using Tumbleweed.Spatial.Point.Coordinate;

namespace Tumbleweed.Spatial.Point;

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