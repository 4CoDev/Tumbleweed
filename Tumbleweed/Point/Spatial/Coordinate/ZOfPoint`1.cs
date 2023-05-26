using Tumbleweed.Scalar;

namespace Tumbleweed.Point.Spatial.Coordinate;

public sealed class ZOfPoint<T> : ScalarEnvelope<T>
{
	public ZOfPoint(IPoint<T> point) : base
	(
		new ResultOfFunction<T>(
			() => point.Z)
	)
	{
	}
}