using Tumbleweed.Scalars;

namespace Tumbleweed.Points.Spatial.Coordinates;

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