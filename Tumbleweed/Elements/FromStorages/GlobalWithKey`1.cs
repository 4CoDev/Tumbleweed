using Tumbleweed.Enumerables.Equality;
using Tumbleweed.Storages;

namespace Tumbleweed.Elements.FromStorages;

public sealed class GlobalWithKey<T> :
	ElementEnvelope<T>
	where T : notnull
{
	public GlobalWithKey(params Object[] key) : this
	(
		new EquatableEnumerable(key)
	)
	{
	}

	public GlobalWithKey(Object key) : base
	(
		new RecordWithKey<T>(
			new GlobalStorage(),
			key)
	)
	{
	}
}