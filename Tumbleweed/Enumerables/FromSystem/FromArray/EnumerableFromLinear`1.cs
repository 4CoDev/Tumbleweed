using Tumbleweed.Scalars;

namespace Tumbleweed.Enumerables.FromSystem.FromArray;

public sealed class EnumerableFromLinear<T> : EnumerableEnvelope<T>
{
	public EnumerableFromLinear
	(
		IScalar<T[]> array
	) : base
	(
		new EnumerableOfDelegate<T>(array.Value.AsEnumerable)
	)
	{
	}
}