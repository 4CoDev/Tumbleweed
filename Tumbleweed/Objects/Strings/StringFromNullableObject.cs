using Tumbleweed.Nullability;
using Tumbleweed.Nullability.FromSystem;
using Tumbleweed.Scalars;

namespace Tumbleweed.Objects.Strings;

public sealed class StringFromNullableObject : NullableEnvelope<String>
{
	public StringFromNullableObject(Object? @object) : this
	(
		new NullableFromSystem<Object>(@object)
	)
	{
	}
	
	public StringFromNullableObject(INullable<Object> @object) : base
	(
		new NullableFromSystem<String>(
			new ResultOfFunction<String?>(
				@object.ToString))
	)
	{
	}
}