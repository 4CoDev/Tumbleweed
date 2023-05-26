namespace Tumbleweed._Enumerable;

public sealed class WithoutLastElement<T> : EnumerableEnvelope<T>
{
	public WithoutLastElement(IEnumerable<T> enumerable) : base
	(
		new _Collection.WithoutLastElement<T>(
			new List<T>(enumerable))
	)
	{
	}
}