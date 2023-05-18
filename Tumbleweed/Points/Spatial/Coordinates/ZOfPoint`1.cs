using Tumbleweed.Scalars;

namespace Tumbleweed.Points.Spatial.Coordinates;

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