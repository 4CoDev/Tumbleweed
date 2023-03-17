namespace Tumbleweed.Enumerables;

public sealed class EnumerableFromElement<T> : EnumerableEnvelope<T>
{
	public EnumerableFromElement
	(
		T element
	) : base
	(
		new EnumerableOfFunction<T>(
			() => new T[] { element })
	)
	{
	}
}