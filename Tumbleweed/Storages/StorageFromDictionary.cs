using Tumbleweed.Nullability;

namespace Tumbleweed.Storages;

public sealed class StorageFromDictionary : IStorage
{
	public StorageFromDictionary
	(
		IDictionary<Object, Object> dictionary
	)
	{
		this.dictionary = dictionary;
	}

	public INullable<Object> ValueWith(Object key)
	{
		Boolean existing = dictionary.TryGetValue(key, out Object? value);
		return new NullableWithValues<Object>(value!, existing);
	}

	public void Add(Object key, Object value) =>
		dictionary.Add(key, value);

	public void RemoveBy(Object key) =>
		dictionary.Remove(key);

	private readonly IDictionary<Object, Object> dictionary;
}