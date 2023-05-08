using Tumbleweed.Scalars;

namespace Tumbleweed.Numbers.Spatial.Coordinates;

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