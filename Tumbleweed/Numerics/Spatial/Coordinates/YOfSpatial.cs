using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Spatial.Coordinates;

public sealed class YOfSpatial<T> : ScalarEnvelope<T>
{
	public YOfSpatial(ISpatial<T> spatial) : base
	(
		new ValueOfFunction<T>(
			() => spatial.Y)
	)
	{
	}
}