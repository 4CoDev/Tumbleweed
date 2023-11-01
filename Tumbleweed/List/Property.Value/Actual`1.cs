using System.Collections;
using Tumbleweed.Property.Output;
using System = System;

namespace Tumbleweed.List.Property.Value;

public sealed class Actual<T> : IList<T>
{
	public Actual(Any<IList<T>> any) =>
		this.any = any;
	
	public IEnumerator<T> GetEnumerator() =>
		any.Value.GetEnumerator();

	IEnumerator IEnumerable.GetEnumerator() =>
		any.Value.GetEnumerator();

	public void Add(T item) => any.Value.Add(item);

	public void Clear() => any.Value.Clear();

	public System::Boolean Contains(T item) =>
		any.Value.Contains(item);

	public void CopyTo(T[] array, Int32 arrayIndex) =>
		any.Value.CopyTo(array, arrayIndex);

	public System::Boolean Remove(T item) =>
		any.Value.Remove(item);

	public Int32 Count => any.Value.Count;

	public System::Boolean IsReadOnly => any.Value.IsReadOnly;

	public Int32 IndexOf(T item) =>
		any.Value.IndexOf(item);

	public void Insert(Int32 index, T item) =>
		any.Value.Insert(index, item);

	public void RemoveAt(Int32 index) =>
		any.Value.RemoveAt(index);

	public T this[Int32 index]
	{
		get => any.Value[index];
		set => any.Value[index] = value;
	}

	private readonly Any<IList<T>> any;
}