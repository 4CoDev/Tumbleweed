using System.Collections;
using Tumbleweed.Scalars;

namespace Tumbleweed.Collections;

public sealed class CollectionOfScalar<T> : ICollection<T>
{
	public CollectionOfScalar(IScalar<ICollection<T>> scalar)
	{
		this.scalar = scalar;
	}

	public IEnumerator<T> GetEnumerator()
	{
		return scalar.Value.GetEnumerator();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}

	public void Add(T item)
	{
		scalar.Value.Add(item);
	}

	public void Clear()
	{
		scalar.Value.Clear();
	}

	public bool Contains(T item)
	{
		return scalar.Value.Contains(item);
	}

	public void CopyTo(T[] array, int arrayIndex)
	{
		scalar.Value.CopyTo(array, arrayIndex);
	}

	public bool Remove(T item)
	{
		return scalar.Value.Remove(item);
	}

	public int Count => scalar.Value.Count;

	public bool IsReadOnly => scalar.Value.IsReadOnly;

	private readonly IScalar<ICollection<T>> scalar;
}