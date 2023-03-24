using Tumbleweed.Enumerables.Equality;
using Tumbleweed.Scalars;
using Tumbleweed.Storages;

namespace Tumbleweed.Elements.FromStorages;

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