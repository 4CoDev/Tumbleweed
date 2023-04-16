using Tumbleweed.Enumerables.Equality;
using Tumbleweed.Nullability;

namespace Tumbleweed.Storages.Elements;

public sealed class RecordWithKey : IStorageElement<Object>
{
	public RecordWithKey(IStorage storage, params Object[] key) : this
	(
		storage, new EquatableEnumerable(key)
	)
	{
	}
	
	public RecordWithKey(IStorage storage, Object key)
	{
		this.storage = storage;
		this.key = key;
	}

	public INullable<Object> Nullable =>
		storage.ValueWith(key);

	public void Remove() =>
		storage.RemoveBy(key);

	public void Place(Object value) =>
		storage.Add(key, value);

	private readonly IStorage storage;

	private readonly Object key;
}