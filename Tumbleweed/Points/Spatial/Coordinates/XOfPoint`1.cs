using Tumbleweed.Scalars;

namespace Tumbleweed.Points.Spatial.Coordinates;

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