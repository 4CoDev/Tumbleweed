using System.Collections;

namespace Tumbleweed.Enumerables;

public abstract class EnumerableEnvelope : IEnumerable
{
	protected EnumerableEnvelope(IEnumerable enumerable) =>
		this.enumerable = enumerable;

	public IEnumerator GetEnumerator() =>
		enumerable.GetEnumerator();
	
	private readonly IEnumerable enumerable;
}