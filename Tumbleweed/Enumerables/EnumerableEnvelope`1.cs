using System.Collections;

namespace Tumbleweed.Enumerables;

public abstract class EnumerableEnvelope<T> : IEnumerable<T>
{
	protected EnumerableEnvelope(IEnumerable<T> enumerable)
	{
		this.enumerable = enumerable;
	}
	
	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
	
	public IEnumerator<T> GetEnumerator()
	{
		return enumerable.GetEnumerator();
	}

	private readonly IEnumerable<T> enumerable;
}