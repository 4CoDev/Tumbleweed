using System.Collections;
using System.Diagnostics.CodeAnalysis;
using Tumbleweed.Scalars;

namespace TumbleGD.Dictionaries;

public sealed class DictionaryFromScalar<TKey, TValue> :
	IDictionary<TKey, TValue>
	where TKey : notnull
{
	public DictionaryFromScalar(IScalar<IDictionary<TKey, TValue>> scalar)
	{
		this.scalar = scalar;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}

	public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
	{
		return scalar.Value().GetEnumerator();
	}

	public void Add(KeyValuePair<TKey, TValue> item)
	{
		scalar.Value().Add(item);
	}

	public void Clear()
	{
		scalar.Value().Clear();
	}

	public bool Contains(KeyValuePair<TKey, TValue> item)
	{
		return scalar.Value().Contains(item);
	}

	public void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
	{
		scalar.Value().CopyTo(array, arrayIndex);
	}

	public bool Remove(KeyValuePair<TKey, TValue> item)
	{
		return scalar.Value().Remove(item);
	}

	public int Count
	{
		get => scalar.Value().Count;
	}

	public bool IsReadOnly
	{
		get => scalar.Value().IsReadOnly;
	}

	public void Add(TKey key, TValue value)
	{
		scalar.Value().Add(key, value);
	}

	public bool ContainsKey(TKey key)
	{
		return scalar.Value().ContainsKey(key);
	}

	public bool Remove(TKey key)
	{
		return scalar.Value().Remove(key);
	}

	public bool TryGetValue(TKey key, [MaybeNullWhen(false)] out TValue value)
	{
		return scalar.Value().TryGetValue(key, out value);
	}

	public TValue this[TKey key]
	{
		get => scalar.Value()[key];
		set => scalar.Value()[key] = value;
	}

	public ICollection<TKey> Keys
	{
		get => scalar.Value().Keys;
	}

	public ICollection<TValue> Values
	{
		get => scalar.Value().Values;
	}

	private readonly IScalar<IDictionary<TKey, TValue>> scalar;
}