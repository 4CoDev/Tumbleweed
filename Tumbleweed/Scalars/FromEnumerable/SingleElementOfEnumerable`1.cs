using Tumbleweed.Enumerables.FromSystem;

namespace Tumbleweed.Scalars.FromEnumerable;

public sealed class SingleElementOfEnumerable<T> : ScalarEnvelope<T>
{
	public SingleElementOfEnumerable
	(
		IEnumerable<T> enumerable
	) : base
	(
		new FromSystem.ElementAtIndex<T>(
			new EnumerableWithSize<T>(enumerable, 1),
			0)
	)
	{
	}
}