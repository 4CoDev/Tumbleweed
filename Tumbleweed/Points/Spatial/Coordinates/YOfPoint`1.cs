using Tumbleweed.Scalars;

namespace Tumbleweed.Points.Spatial.Coordinates;

public sealed class YOfPoint<T> : ScalarEnvelope<T>
{
	public YOfPoint(IPoint<T> point) : base
	(
		new ResultOfFunction<T>(
			() => point.Y)
	)
	{
	}
}