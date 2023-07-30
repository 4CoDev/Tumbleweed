using System.Collections;
using System.Diagnostics.CodeAnalysis;
using Tumbleweed.Scalar;
using Tumbleweed.Scalar.Immutable;
using System = System;

namespace Tumbleweed.Dictionary;

public sealed class DictionaryOfScalar<TKey, TValue> :
	IDictionary<TKey, TValue>
	where TKey : notnull
{
	public DictionaryOfScalar(Any<IDictionary<TKey, TValue>> any)
	{
		this.any = any;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}

	public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
	{
		return any.Value.GetEnumerator();
	}

	public void Add(KeyValuePair<TKey, TValue> item)
	{
		any.Value.Add(item);
	}

	public void Clear()
	{
		any.Value.Clear();
	}

	public System::Boolean Contains(KeyValuePair<TKey, TValue> item)
	{
		return any.Value.Contains(item);
	}

	public void CopyTo(KeyValuePair<TKey, TValue>[] array, Int32 arrayIndex)
	{
		any.Value.CopyTo(array, arrayIndex);
	}

	public System::Boolean Remove(KeyValuePair<TKey, TValue> item)
	{
		return any.Value.Remove(item);
	}

	public Int32 Count => any.Value.Count;

	public System::Boolean IsReadOnly => any.Value.IsReadOnly;

	public void Add(TKey key, TValue value)
	{
		any.Value.Add(key, value);
	}

	public System::Boolean ContainsKey(TKey key)
	{
		return any.Value.ContainsKey(key);
	}

	public System::Boolean Remove(TKey key)
	{
		return any.Value.Remove(key);
	}

	public System::Boolean TryGetValue(TKey key, [MaybeNullWhen(false)] out TValue value)
	{
		return any.Value.TryGetValue(key, out value);
	}

	public TValue this[TKey key]
	{
		get => any.Value[key];
		set => any.Value[key] = value;
	}

	public ICollection<TKey> Keys => any.Value.Keys;

	public ICollection<TValue> Values => any.Value.Values;

	private readonly Any<IDictionary<TKey, TValue>> any;
}