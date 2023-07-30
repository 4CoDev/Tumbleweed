using System.Collections;
using Tumbleweed.Scalar;
using Tumbleweed.Scalar.Immutable;
using System = System;

namespace Tumbleweed.Collection;

public sealed class CollectionOfScalar<T> : ICollection<T>
{
	public CollectionOfScalar(Any<ICollection<T>> any)
	{
		this.any = any;
	}

	public IEnumerator<T> GetEnumerator()
	{
		return any.Value.GetEnumerator();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}

	public void Add(T item)
	{
		any.Value.Add(item);
	}

	public void Clear()
	{
		any.Value.Clear();
	}

	public System::Boolean Contains(T item)
	{
		return any.Value.Contains(item);
	}

	public void CopyTo(T[] array, Int32 arrayIndex)
	{
		any.Value.CopyTo(array, arrayIndex);
	}

	public System::Boolean Remove(T item)
	{
		return any.Value.Remove(item);
	}

	public Int32 Count => any.Value.Count;

	public System::Boolean IsReadOnly => any.Value.IsReadOnly;

	private readonly Any<ICollection<T>> any;
}