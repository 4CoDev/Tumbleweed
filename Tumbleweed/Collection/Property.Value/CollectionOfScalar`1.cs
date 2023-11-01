using System.Collections;
using Tumbleweed.Property.Output;
using System = System;

namespace Tumbleweed.Collection.Property.Value;

public sealed class Actual<T> : ICollection<T>
{
	public Actual(Any<ICollection<T>> any)
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