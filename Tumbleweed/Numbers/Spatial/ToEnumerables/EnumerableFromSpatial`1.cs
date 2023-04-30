using Tumbleweed.Enumerables;

namespace Tumbleweed.Numbers.Spatial.ToEnumerables;

public sealed class EnumerableFromSpatial<T> : EnumerableEnvelope<T>
{
	public EnumerableFromSpatial(ISpatial<T> spatial) : base
	(
		new EnumerableWithElements<T>(
			spatial.X,
			spatial.Y,
			spatial.Z)
	)
	{
	}
}