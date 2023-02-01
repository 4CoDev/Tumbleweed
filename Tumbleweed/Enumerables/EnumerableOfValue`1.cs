namespace Tumbleweed.Enumerables;

public sealed class EnumerableOfValue<T> : EnumerableEnvelope<T>
{
	public EnumerableOfValue(T value) : base
	(
		new T[] { value }
	)
	{
	}
}