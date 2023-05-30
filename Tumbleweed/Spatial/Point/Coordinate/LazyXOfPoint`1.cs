using Tumbleweed.Scalar;

namespace Tumbleweed.Spatial.Point.Coordinate;

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