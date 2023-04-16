using Tumbleweed.Enumerables.Equality;

namespace Tumbleweed.Storages.Elements;

public sealed class RecordWithKey<T> :
	ElementEnvelope<T>
	where T : notnull
{
	public RecordWithKey
	(
		IStorage storage,
		params Object[] key
	) : this
	(
		storage,
		new EquatableEnumerable(key)
	)
	{
	}
	
	public RecordWithKey(IStorage storage, Object key) : base
	(
		new ElementAsType<T>(
			new RecordWithKey(storage, key))
	)
	{
	}
}