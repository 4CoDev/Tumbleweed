using Tumbleweed.Scalar;

namespace Tumbleweed.Point.Planar;

public sealed class LazyPoint<T> : PointEnvelope<T>
{
	public LazyPoint(IPoint<T> point) : base
	(
		new PointWithCoordinates<T>(
			new LazyResultOfFunction<T>(() => point.X),
			new LazyResultOfFunction<T>(() => point.Y))
	)
	{
	}
}