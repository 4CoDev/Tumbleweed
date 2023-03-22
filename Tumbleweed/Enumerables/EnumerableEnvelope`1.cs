using System.Collections;

namespace Tumbleweed.Enumerables;

public abstract class EnumerableEnvelope<T> : IEnumerable<T>
{
	protected EnumerableEnvelope(IEnumerable<T> enumerable) =>
		this.enumerable = enumerable;
	
	IEnumerator IEnumerable.GetEnumerator() =>
		GetEnumerator();
	
	public IEnumerator<T> GetEnumerator() =>
		enumerable.GetEnumerator();
	
	public override Boolean Equals(Object? @object) =>
		enumerable.Equals(@object);

	public override Int32 GetHashCode() =>
		enumerable.GetHashCode();

	public override String? ToString() =>
		enumerable.ToString();

	private readonly IEnumerable<T> enumerable;
}