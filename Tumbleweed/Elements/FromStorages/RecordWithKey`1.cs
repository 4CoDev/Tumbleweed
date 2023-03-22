using Tumbleweed.Arrays.Equality.OfSystem;
using Tumbleweed.Scalars;
using Tumbleweed.Storages;

namespace Tumbleweed.Elements.FromStorages;

public sealed class RecordWithKey<T> : ElementEnvelope<T> where T : notnull
{
	public RecordWithKey(IStorage storage, params Object[] key) : this
	(
		storage, new EquatableArray(key)
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