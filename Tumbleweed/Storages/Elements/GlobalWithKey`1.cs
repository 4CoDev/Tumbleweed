using Tumbleweed.Enumerables.Equality;

namespace Tumbleweed.Storages.Elements;

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