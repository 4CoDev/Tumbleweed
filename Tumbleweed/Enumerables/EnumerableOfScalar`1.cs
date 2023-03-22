using System.Collections;
using Tumbleweed.Scalars;

namespace Tumbleweed.Enumerables;

public sealed class EnumerableOfScalar<T> : IEnumerable<T>
{
	public EnumerableOfScalar(IScalar<IEnumerable<T>> scalar) =>
		this.scalar = scalar;

	IEnumerator IEnumerable.GetEnumerator() =>
		scalar.Value.GetEnumerator();
	
	public IEnumerator<T> GetEnumerator() =>
		scalar.Value.GetEnumerator();
	
	public override Boolean Equals(Object? @object) =>
		scalar.Value.Equals(@object);

	public override Int32 GetHashCode() =>
		scalar.Value.GetHashCode();
	
	public override String? ToString() =>
		scalar.Value.ToString();

	private readonly IScalar<IEnumerable<T>> scalar;
}