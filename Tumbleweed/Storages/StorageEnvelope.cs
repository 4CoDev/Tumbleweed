using Tumbleweed.Nullability;

namespace Tumbleweed.Storages;

public abstract class StorageEnvelope : IStorage
{
	protected StorageEnvelope(IStorage storage) =>
		this.storage = storage;

	public INullable<Object> ValueWith(Object key) =>
		storage.ValueWith(key);

	public void Add(Object key, Object value) =>
		storage.Add(key, value);

	public void RemoveBy(Object key) =>
		storage.RemoveBy(key);
	
	private readonly IStorage storage;
}