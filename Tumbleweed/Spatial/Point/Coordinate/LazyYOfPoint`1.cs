using Tumbleweed.Scalar;

namespace Tumbleweed.Spatial.Point.Coordinate;

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