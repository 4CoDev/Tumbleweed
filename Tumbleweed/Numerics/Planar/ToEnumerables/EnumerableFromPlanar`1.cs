using Tumbleweed.Enumerables;
using Tumbleweed.Numerics.Spatial;

namespace Tumbleweed.Numerics.Planar.ToEnumerables;

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