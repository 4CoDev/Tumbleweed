namespace Tumbleweed.Enumerables;

public sealed class EnumerableFromElement<T> : EnumerableEnvelope<T>
{
	public EnumerableFromElement
	(
		T element
	) : base
	(
		new EnumerableOfDelegate<T>(
			() => new T[] { element })
	)
	{
	}
}