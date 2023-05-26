using System.Collections;
using Tumbleweed.Scalar;

namespace Tumbleweed._List;

public sealed class ListOfScalar<T> : IList<T>
{
	public ListOfScalar(IScalar<IList<T>> scalar) =>
		this.scalar = scalar;
	
	public IEnumerator<T> GetEnumerator() =>
		scalar.Value.GetEnumerator();

	IEnumerator IEnumerable.GetEnumerator() =>
		scalar.Value.GetEnumerator();

	public void Add(T item) => scalar.Value.Add(item);

	public void Clear() => scalar.Value.Clear();

	public Boolean Contains(T item) =>
		scalar.Value.Contains(item);

	public void CopyTo(T[] array, Int32 arrayIndex) =>
		scalar.Value.CopyTo(array, arrayIndex);

	public Boolean Remove(T item) =>
		scalar.Value.Remove(item);

	public Int32 Count => scalar.Value.Count;

	public Boolean IsReadOnly => scalar.Value.IsReadOnly;

	public Int32 IndexOf(T item) =>
		scalar.Value.IndexOf(item);

	public void Insert(Int32 index, T item) =>
		scalar.Value.Insert(index, item);

	public void RemoveAt(Int32 index) =>
		scalar.Value.RemoveAt(index);

	public T this[Int32 index]
	{
		get => scalar.Value[index];
		set => scalar.Value[index] = value;
	}

	private readonly IScalar<IList<T>> scalar;
}