using System.Collections;

namespace Tumbleweed._List;

public abstract class ListEnvelope<T> : IList<T>
{
	protected ListEnvelope(IList<T> list) =>
		this.list = list;
	
	public IEnumerator<T> GetEnumerator() =>
		list.GetEnumerator();

	IEnumerator IEnumerable.GetEnumerator() =>
		list.GetEnumerator();

	public void Add(T item) =>
		list.Add(item);

	public void Clear() => list.Clear();

	public Boolean Contains(T item) => list.Contains(item);

	public void CopyTo(T[] array, Int32 arrayIndex) =>
		list.CopyTo(array, arrayIndex);

	public Boolean Remove(T item) => list.Remove(item);

	public Int32 Count => list.Count;

	public Boolean IsReadOnly => list.IsReadOnly;

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