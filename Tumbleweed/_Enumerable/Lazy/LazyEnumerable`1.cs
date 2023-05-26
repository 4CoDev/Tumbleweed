using Tumbleweed.Scalar;

namespace Tumbleweed._Enumerable.Lazy;

public sealed class LazyEnumerable<T> : EnumerableEnvelope<T>
{
	public LazyEnumerable(IEnumerable<T> enumerable) : base
	(
		new EnumerableOfScalar<T>(
			new LazyResultOfFunction<IEnumerable<T>>(
				() => new List<T>(enumerable)))
	)
	{
	}
}