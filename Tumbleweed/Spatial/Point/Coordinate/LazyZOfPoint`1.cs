using Tumbleweed.Scalar;

namespace Tumbleweed.Spatial.Point.Coordinate;

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