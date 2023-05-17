using Tumbleweed.Scalars;

namespace Tumbleweed.Points.Spatial.Coordinates;

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