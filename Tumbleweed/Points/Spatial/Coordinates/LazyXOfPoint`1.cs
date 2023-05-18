using Tumbleweed.Scalars;

namespace Tumbleweed.Points.Spatial.Coordinates;

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