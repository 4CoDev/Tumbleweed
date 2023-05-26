using Tumbleweed.Scalar;

namespace Tumbleweed.Nullable;

public sealed class NullableAsType<T> :
	NullableEnvelope<T>
{
	public NullableAsType(INullable<Object> origin) : base
	(
		new NullableWithValues<T>(
			new ObjectAsType<T>(
				new ValueOfNullable<Object>(origin)),
			new IsValueExists(origin))
	)
	{
	}
}