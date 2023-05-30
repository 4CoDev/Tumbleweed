using Tumbleweed._Enumerable;

namespace Tumbleweed.Spatial.Point.Enumerable;

public sealed class EnumerableFromSpatial<T> : EnumerableEnvelope<T>
{
	public EnumerableFromSpatial(IPoint<T> point) : base
	(
		new EnumerableWithElements<T>(
			point.X,
			point.Y,
			point.Z)
	)
	{
	}
}