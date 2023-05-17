using Tumbleweed.Enumerables;

namespace Tumbleweed.Points.Planar.ToEnumerables;

public sealed class EnumerableFromPlanar<T> : EnumerableEnvelope<T>
{
	public EnumerableFromPlanar(IPlanar<T> spatial) : base
	(
		new EnumerableWithElements<T>(
			spatial.X,
			spatial.Y)
	)
	{
	}
}