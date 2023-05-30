using Tumbleweed.Scalar;

namespace Tumbleweed.Planar.Point.Coordinate;

public sealed class LazyYOfPoint<T> : ScalarEnvelope<T>
{
	public LazyYOfPoint(IPoint<T> point) : base
	(
		new LazyValue<T>(
			new YOfPoint<T>(point))
	)
	{
	}
}