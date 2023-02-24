using Tumbleweed.Scalars;

namespace Tumbleweed.Enumerables.FromSystem.FromArray;

public sealed class EnumerableFromSpatial<T> : EnumerableEnvelope<T>
{
	public EnumerableFromSpatial
	(
		IScalar<T[,,]> array
	) : base
	(
		new EnumerableOfDelegate<T>(array.Value.Cast<T>)
	)
	{
	}
}