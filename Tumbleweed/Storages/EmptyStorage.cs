namespace Tumbleweed.Storages;

public sealed class EmptyStorage : StorageEnvelope
{
	public EmptyStorage() : base
	(
		new StorageFromDictionary(
			new Dictionary<Object, Object>())
	)
	{
	}
}