using Tumbleweed.Scalars;

namespace Tumbleweed.Points.Spatial.Coordinates;

public sealed class ZOfSpatial<T> : ScalarEnvelope<T>
{
	public ZOfSpatial(ISpatial<T> spatial) : base
	(
		new ResultOfFunction<T>(
			() => spatial.Z)
	)
	{
	}
}