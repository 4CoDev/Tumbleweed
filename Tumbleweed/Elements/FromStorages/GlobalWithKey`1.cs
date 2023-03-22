using Tumbleweed.Arrays.Equality.OfSystem;
using Tumbleweed.Scalars;
using Tumbleweed.Storages;

namespace Tumbleweed.Elements.FromStorages;

public sealed class GlobalWithKey<T> :
	ElementEnvelope<T>
	where T : notnull
{
	public GlobalWithKey(params Object[] key) : this
	(
		new EquatableArray(key)
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