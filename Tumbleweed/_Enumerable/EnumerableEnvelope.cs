using System.Collections;

namespace Tumbleweed._Enumerable;

public abstract class EnumerableEnvelope : IEnumerable
{
	protected EnumerableEnvelope(IEnumerable enumerable) =>
		this.enumerable = enumerable;

	public IEnumerator GetEnumerator() =>
		enumerable.GetEnumerator();
	
	public override Boolean Equals(Object? @object) =>
		enumerable.Equals(@object);

	public override Int32 GetHashCode() =>
		enumerable.GetHashCode();

	public override String? ToString() =>
		enumerable.ToString();
	
	private readonly IEnumerable enumerable;
}