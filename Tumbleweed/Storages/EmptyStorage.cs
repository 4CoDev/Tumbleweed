namespace Tumbleweed.Storages;

public sealed class EmptyStorage : StorageEnvelope
{
	public EmptyStorage() : base
	(
		new StorageWithRecords(
			new Dictionary<Object, Object>())
	)
	{
	}
}