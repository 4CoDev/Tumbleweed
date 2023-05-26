using Tumbleweed.Scalar;

namespace Tumbleweed.Point.Planar.Coordinate;

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