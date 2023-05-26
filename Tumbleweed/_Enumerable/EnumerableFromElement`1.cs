namespace Tumbleweed._Enumerable;

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