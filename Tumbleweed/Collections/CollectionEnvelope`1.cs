using System.Collections;

namespace Tumbleweed.Collections;

public abstract class CollectionEnvelope<T> : ICollection<T>
{
	protected CollectionEnvelope(Func<ICollection<T>> @delegate) : this
	(
		new CollectionOfDelegate<T>(@delegate)
	)
	{
	}

	protected CollectionEnvelope(ICollection<T> collection)
	{
		this.collection = collection;
	}

	public IEnumerator<T> GetEnumerator()
	{
		return collection.GetEnumerator();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}

	public void Add(T item)
	{
		collection.Add(item);
	}

	public void Clear()
	{
		collection.Clear();
	}

	public bool Contains(T item)
	{
		return collection.Contains(item);
	}

	public void CopyTo(T[] array, int arrayIndex)
	{
		collection.CopyTo(array, arrayIndex);
	}

	public bool Remove(T item)
	{
		return collection.Remove(item);
	}

	public int Count
	{
		get => collection.Count;
	}

	public bool IsReadOnly
	{
		get => collection.IsReadOnly;
	}
	
	private readonly ICollection<T> collection;
}