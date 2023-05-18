using Tumbleweed.Enumerables;

namespace Tumbleweed.Points.Planar.Enumerables;

public sealed class EnumerableFromPlanar<T> : EnumerableEnvelope<T>
{
	public EnumerableFromPlanar(IPoint<T> spatial) : base
	(
		new EnumerableWithElements<T>(
			spatial.X,
			spatial.Y)
	)
	{
	}
}