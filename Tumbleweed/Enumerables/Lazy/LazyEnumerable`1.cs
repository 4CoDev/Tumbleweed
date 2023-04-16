using Tumbleweed.Scalars;

namespace Tumbleweed.Enumerables.Lazy;

public sealed class LazyEnumerable<T> : EnumerableEnvelope<T>
{
	public LazyEnumerable(IEnumerable<T> enumerable) : base
	(
		new EnumerableOfScalar<T>(
			new LazyFunction<IEnumerable<T>>(
				() => new List<T>(enumerable)))
	)
	{
	}
}