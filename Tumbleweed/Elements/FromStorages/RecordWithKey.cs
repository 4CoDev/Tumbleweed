using Tumbleweed.Dictionaries;
using Tumbleweed.Scalars;
using Tumbleweed.Storages;

namespace Tumbleweed.Elements.FromStorages;

public sealed class RecordWithKey : ElementEnvelope<Object>
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
		new FromDictionaries.ElementWithKey<Object, Object>(
			new DictionaryOfFunction<Object, Object>(
				() => storage.Records),
			key)
	)
	{
	}
}