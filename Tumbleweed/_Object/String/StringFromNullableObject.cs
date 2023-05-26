using Tumbleweed._String;
using Tumbleweed._String.Nullable;
using Tumbleweed.Nullable;
using Tumbleweed.Nullable.FromSystem;
using Tumbleweed.Scalar;

namespace Tumbleweed._Object.String;

public sealed class StringFromNullableObject : NullableEnvelope<IString>
{
	public StringFromNullableObject(Object? @object) : this
	(
		new NullableFromSystem<Object>(@object)
	)
	{
	}
	
	public StringFromNullableObject(INullable<Object> @object) : base
	(
		new NullableFromSystem(
				new ResultOfFunction<System.String?>(
					@object.ToString))
	)
	{
	}
}