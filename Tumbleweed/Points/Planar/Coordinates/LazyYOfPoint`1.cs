using Tumbleweed.Scalars;

namespace Tumbleweed.Points.Planar.Coordinates;

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