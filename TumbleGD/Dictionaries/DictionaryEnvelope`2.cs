using System.Collections;
using System.Diagnostics.CodeAnalysis;

namespace TumbleGD.Dictionaries;

public abstract class DictionaryEnvelope<TKey, TValue> :
	IDictionary<TKey, TValue>
	where TKey : notnull
{
	protected DictionaryEnvelope(IDictionary<TKey, TValue> dictionary)
	{
		this.dictionary = dictionary;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}

	public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
	{
		return dictionary.GetEnumerator();
	}

	public void Add(KeyValuePair<TKey, TValue> item)
	{
		dictionary.Add(item);
	}

	public void Clear()
	{
		dictionary.Clear();
	}

	public bool Contains(KeyValuePair<TKey, TValue> item)
	{
		return dictionary.Contains(item);
	}

	public void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
	{
		dictionary.CopyTo(array, arrayIndex);
	}

	public bool Remove(KeyValuePair<TKey, TValue> item)
	{
		return dictionary.Remove(item);
	}

	public int Count => dictionary.Count;

	public bool IsReadOnly => dictionary.IsReadOnly;

	public void Add(TKey key, TValue value)
	{
		dictionary.Add(key, value);
	}

	public bool ContainsKey(TKey key)
	{
		return dictionary.ContainsKey(key);
	}

	public bool Remove(TKey key)
	{
		return dictionary.Remove(key);
	}

	public bool TryGetValue(TKey key, [MaybeNullWhen(false)] out TValue value)
	{
		return dictionary.TryGetValue(key, out value);
	}

	public TValue this[TKey key]
	{
		get => dictionary[key];
		set => dictionary[key] = value;
	}

	public ICollection<TKey> Keys => dictionary.Keys;

	public ICollection<TValue> Values => dictionary.Values;

	private readonly IDictionary<TKey, TValue> dictionary;
}