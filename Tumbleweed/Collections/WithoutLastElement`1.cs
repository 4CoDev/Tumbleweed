using Tumbleweed.Enumerables;

namespace Tumbleweed.Collections;

public sealed class WithoutLastElement<T> : EnumerableEnvelope<T>
{
	public WithoutLastElement(ICollection<T> collection) : base
	(
		new EnumerableOfFunction<T>(
			() => new List<T>(
				collection.Take(
					collection.Count - 1)))
	)
	{
	}
}