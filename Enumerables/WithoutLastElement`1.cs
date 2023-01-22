using Tumbleweed.Scalars;

namespace Tumbleweed.Enumerables;

public sealed class WithoutLastElement<T> : EnumerableEnvelope<T>
{
	public WithoutLastElement(IEnumerable<T> enumerable) : base
	(
		new CuttedFromLast<T>(enumerable, new ScalarOfValue<int>(1))
	)
	{
	}
}