using Tumbleweed.Scalar;

namespace Tumbleweed.Planar.Point.Coordinate;

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