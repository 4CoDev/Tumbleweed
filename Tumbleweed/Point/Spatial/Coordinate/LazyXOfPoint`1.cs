using Tumbleweed.Scalar;

namespace Tumbleweed.Point.Spatial.Coordinate;

public sealed class LazyXOfPoint<T> : ScalarEnvelope<T>
{
	public LazyXOfPoint(IPoint<T> point) : base
	(
		new LazyValue<T>(
			new XOfPoint<T>(point))
	)
	{
	}
}