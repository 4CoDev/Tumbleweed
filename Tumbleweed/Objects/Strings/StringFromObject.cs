using Tumbleweed.Nullables;
using Tumbleweed.Nullables.FromSystem;
using Tumbleweed.Scalars;

namespace Tumbleweed.Objects.Strings;

public sealed class StringFromObject : NullableEnvelope<String>
{
	public StringFromObject(Object @object) : this
	(
		new ScalarValue<Object>(@object)
	)
	{
	}
	
	public StringFromObject(IScalar<Object> @object) : base
	(
		new NullableFromSystem<String>(
			new ResultOfFunction<String?>(
				() => @object.Value.ToString()))
	)
	{
	}
}