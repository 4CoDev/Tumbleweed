using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Spatial.Coordinates;

public sealed class XOfSpatial<T> : ScalarEnvelope<T>
{
	public XOfSpatial(ISpatial<T> spatial) : base
	(
		new ValueOfFunction<T>(
			() => spatial.X)
	)
	{
	}
}