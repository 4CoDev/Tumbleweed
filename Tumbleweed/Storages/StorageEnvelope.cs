namespace Tumbleweed.Storages;

public abstract class StorageEnvelope : IStorage
{
	protected StorageEnvelope(IStorage storage) =>
		this.storage = storage;

	public IDictionary<Object, Object> Records =>
		this.storage.Records;
	
	private readonly IStorage storage;
}