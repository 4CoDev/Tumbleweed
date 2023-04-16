using Tumbleweed.Enumerables.Equality;

namespace Tumbleweed.Storages.Elements;

public sealed class GlobalWithKey : ElementEnvelope<Object>
{
	public GlobalWithKey(params Object[] key) : this
	(
		new EquatableEnumerable(key)
	)
	{
	}
	
	public GlobalWithKey(Object key) : base
	(
		new RecordWithKey(
			new GlobalStorage(),
			key)
	)
	{
	}
}