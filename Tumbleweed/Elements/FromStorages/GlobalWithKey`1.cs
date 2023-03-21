using Tumbleweed.Scalars;
using Tumbleweed.Storages;

namespace Tumbleweed.Elements.FromStorages;

public sealed class GlobalWithKey<T> : ElementEnvelope<T>
{
	public GlobalWithKey(params Object[] key) : this
	(
		new ValueAsType<Object>(key)
	)
	{
	}

	public GlobalWithKey(Object key) : this
	(
		new ScalarOfValue(key)
	)
	{
	}
	
	public GlobalWithKey(IScalar<Object> key) : base
	(
		new RecordWithKey<T>(
			new GlobalStorage(),
			key)
	)
	{
	}
}