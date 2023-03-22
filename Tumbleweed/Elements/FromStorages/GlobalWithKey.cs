using System.Collections;
using Tumbleweed.Arrays.Equality.OfSystem;
using Tumbleweed.Scalars;
using Tumbleweed.Storages;

namespace Tumbleweed.Elements.FromStorages;

public sealed class GlobalWithKey : ElementEnvelope<Object>
{
	public GlobalWithKey(params Object[] key) : this
	(
		new EquatableArray(key)
	)
	{
	}
	
	public GlobalWithKey(IScalar<Object> key) : base
	(
		new RecordWithKey(
			new GlobalStorage(),
			key)
	)
	{
	}
}