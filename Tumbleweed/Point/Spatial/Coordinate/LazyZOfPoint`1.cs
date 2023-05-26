using Tumbleweed.Scalar;

namespace Tumbleweed.Point.Spatial.Coordinate;

public sealed class LazyZOfPoint<T> : ScalarEnvelope<T>
{
	public LazyZOfPoint(IPoint<T> point) : base
	(
		new LazyValue<T>(
			new ZOfPoint<T>(point))
	)
	{
	}
}