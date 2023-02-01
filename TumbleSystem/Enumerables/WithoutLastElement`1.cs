using Tumbleweed.Enumerables;

namespace TumbleSystem.Enumerables;

public sealed class WithoutLastElement<T> : EnumerableEnvelope<T>
{
	public WithoutLastElement(IEnumerable<T> enumerable) : base
	(
		new Collections.WithoutLastElement<T>(new List<T>(enumerable))
	)
	{
	}
}