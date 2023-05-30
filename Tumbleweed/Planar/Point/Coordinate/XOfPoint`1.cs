using Tumbleweed.Scalar;

namespace Tumbleweed.Planar.Point.Coordinate;

public sealed class XOfPoint<T> : ScalarEnvelope<T>
{
	public XOfPoint(IPoint<T> point) : base
	(
		new ResultOfFunction<T>(
			() => point.X)
	)
	{
	}
}