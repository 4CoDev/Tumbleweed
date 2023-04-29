using Tumbleweed.Enumerables.FromSystem;

namespace Tumbleweed.Scalars.FromEnumerable;

public sealed class SingleOfEnumerable<T> : ScalarEnvelope<T>
{
	public SingleOfEnumerable
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