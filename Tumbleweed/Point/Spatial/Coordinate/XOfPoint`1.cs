using Tumbleweed.Scalar;

namespace Tumbleweed.Point.Spatial.Coordinate;

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