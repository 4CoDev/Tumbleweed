using Tumbleweed.Scalars;

namespace Tumbleweed.Numbers.Spatial.Coordinates;

public sealed class XOfSpatial<T> : ScalarEnvelope<T>
{
	public XOfSpatial(ISpatial<T> spatial) : base
	(
		new ResultOfFunction<T>(
			() => spatial.X)
	)
	{
	}
}