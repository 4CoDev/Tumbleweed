using System.Collections;
using Tumbleweed.Scalars;

namespace Tumbleweed.Enumerables;

public sealed class EnumerableOfScalar<T> : IEnumerable<T>
{
	public EnumerableOfScalar(IScalar<IEnumerable<T>> scalar)
	{
		this.scalar = scalar;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
	
	public IEnumerator<T> GetEnumerator()
	{
		return scalar.Value.GetEnumerator();
	}

	private readonly IScalar<IEnumerable<T>> scalar;
}