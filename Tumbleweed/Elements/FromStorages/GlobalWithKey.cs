using System.Collections;
using Tumbleweed.Enumerables.Equality;
using Tumbleweed.Scalars;
using Tumbleweed.Storages;

namespace Tumbleweed.Elements.FromStorages;

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