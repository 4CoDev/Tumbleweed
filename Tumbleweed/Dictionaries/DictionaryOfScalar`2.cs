using System.Collections;
using System.Diagnostics.CodeAnalysis;
using Tumbleweed.Scalars;

namespace Tumbleweed.Dictionaries;

public sealed class DictionaryOfScalar<TKey, TValue> :
	IDictionary<TKey, TValue>
	where TKey : notnull
{
	public DictionaryOfScalar(IScalar<IDictionary<TKey, TValue>> scalar)
	{
		this.scalar = scalar;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}

	public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
	{
		return scalar.Value.GetEnumerator();
	}

	public void Add(KeyValuePair<TKey, TValue> item)
	{
		scalar.Value.Add(item);
	}

	public void Clear()
	{
		scalar.Value.Clear();
	}

	public Boolean Contains(KeyValuePair<TKey, TValue> item)
	{
		return scalar.Value.Contains(item);
	}

	public void CopyTo(KeyValuePair<TKey, TValue>[] array, Int32 arrayIndex)
	{
		scalar.Value.CopyTo(array, arrayIndex);
	}

	public Boolean Remove(KeyValuePair<TKey, TValue> item)
	{
		return scalar.Value.Remove(item);
	}

	public Int32 Count => scalar.Value.Count;

	public Boolean IsReadOnly => scalar.Value.IsReadOnly;

	public void Add(TKey key, TValue value)
	{
		scalar.Value.Add(key, value);
	}

	public Boolean ContainsKey(TKey key)
	{
		return scalar.Value.ContainsKey(key);
	}

	public Boolean Remove(TKey key)
	{
		return scalar.Value.Remove(key);
	}

	public Boolean TryGetValue(TKey key, [MaybeNullWhen(false)] out TValue value)
	{
		return scalar.Value.TryGetValue(key, out value);
	}

	public TValue this[TKey key]
	{
		get => scalar.Value[key];
		set => scalar.Value[key] = value;
	}

	public ICollection<TKey> Keys => scalar.Value.Keys;

	public ICollection<TValue> Values => scalar.Value.Values;

	private readonly IScalar<IDictionary<TKey, TValue>> scalar;
}