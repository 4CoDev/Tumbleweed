namespace Tumbleweed.Storage;

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