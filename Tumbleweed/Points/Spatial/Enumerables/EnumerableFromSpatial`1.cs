using Tumbleweed.Enumerables;

namespace Tumbleweed.Points.Spatial.Enumerables;

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