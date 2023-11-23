using System.Collections;
using System = System;

namespace Tumbleweed.List;

public abstract class Envelope<T> : IList<T>
{
	protected Envelope(IList<T> list) =>
		this.list = list;
	
	public IEnumerator<T> GetEnumerator() =>
		list.GetEnumerator();

	IEnumerator IEnumerable.GetEnumerator() =>
		list.GetEnumerator();

	public void Add(T item) =>
		list.Add(item);

	public void Clear() => list.Clear();

	public System::Boolean Contains(T item) => list.Contains(item);

	public void CopyTo(T[] array, Int32 arrayIndex) =>
		list.CopyTo(array, arrayIndex);

	public System::Boolean Remove(T item) => list.Remove(item);

	public Int32 Count => list.Count;

	public System::Boolean IsReadOnly => list.IsReadOnly;

	public Int32 IndexOf(T item) => list.IndexOf(item);

	public void Insert(Int32 index, T item) =>
		list.Insert(index, item);

	public void RemoveAt(Int32 index) => list.RemoveAt(index);

	public T this[Int32 index]
	{
		get => list[index];
		set => list[index] = value;
	}

	private readonly IList<T> list;
}