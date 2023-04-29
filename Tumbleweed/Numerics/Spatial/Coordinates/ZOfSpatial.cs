using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Spatial.Coordinates;

public sealed class ZOfSpatial<T> : ScalarEnvelope<T>
{
	public ZOfSpatial(ISpatial<T> spatial) : base
	(
		new ValueOfFunction<T>(
			() => spatial.Z)
	)
	{
	}
}