using Tumbleweed._String;
using Tumbleweed._String.Nullable;
using Tumbleweed.Nullable;
using Tumbleweed.Scalar;

namespace Tumbleweed._Object.String;

public sealed class StringFromObject : NullableEnvelope<IString>
{
	public StringFromObject(Object @object) : this
	(
		new ScalarValue<Object>(@object)
	)
	{
	}
	
	public StringFromObject(IScalar<Object> @object) : base
	(
		new NullableFromSystem(
			new ResultOfFunction<System.String?>(
				() => @object.Value.ToString()))
	)
	{
	}
}