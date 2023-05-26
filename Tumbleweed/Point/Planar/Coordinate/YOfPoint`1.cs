using Tumbleweed.Scalar;

namespace Tumbleweed.Point.Planar.Coordinate;

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