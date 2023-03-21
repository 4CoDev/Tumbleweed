namespace Tumbleweed.Storages;

public sealed class StorageWithRecords : IStorage
{
	public StorageWithRecords
	(
		IDictionary<Object, Object> records
	)
	{
		Records = records;
	}

	public IDictionary<Object, Object> Records { get; }
}