using Tumbleweed.Scalars;
using Tumbleweed.Storages;

namespace Tumbleweed.Elements.FromStorages;

public sealed class RecordWithKey<T> : ElementEnvelope<T>
{
	public RecordWithKey(IStorage storage, params Object[] key) : this
	(
		storage, new ValueAsType<Object>(key)
	)
	{
	}

	public RecordWithKey(IStorage storage, Object key) : this
	(
		storage, new ScalarOfValue(key)
	)
	{
	}
	
	public RecordWithKey(IStorage storage, IScalar<Object> key) : base
	(
		new ElementAsType<T>(
			new RecordWithKey(storage, key))
	)
	{
	}
}