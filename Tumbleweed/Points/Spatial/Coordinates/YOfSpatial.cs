using Tumbleweed.Scalars;

namespace Tumbleweed.Points.Spatial.Coordinates;

public sealed class YOfSpatial<T> : ScalarEnvelope<T>
{
	public YOfSpatial(ISpatial<T> spatial) : base
	(
		new ResultOfFunction<T>(
			() => spatial.Y)
	)
	{
	}
}